using DataAccess.UnitOfWorks;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Presentation.Filter
{
    public class ArticleVisitorFilter : IAsyncActionFilter
    {
        private readonly IUnitOfWork unitOfWork;

        public ArticleVisitorFilter(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }



        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context == null || context.HttpContext == null || context.HttpContext.Connection == null)
            {
               
                return;
            }

   
            List<Visitor> visitors = await unitOfWork.GetRepository<Visitor>().GetAllAsync();


            string? getIp = context.HttpContext.Connection.RemoteIpAddress?.MapToIPv4()?.ToString();
            string getUserAgent = context.HttpContext.Request.Headers["User-Agent"];

      
            if (getIp == null)
            {
            

                return;
            }



            Visitor visitor = new Visitor(getIp, getUserAgent);


            if (!visitors.Any(x => x.IpAddress == visitor.IpAddress))
            {
                await unitOfWork.GetRepository<Visitor>().AddAsync(visitor);
                unitOfWork.Save();
            }

            await next();

        }
    }
}