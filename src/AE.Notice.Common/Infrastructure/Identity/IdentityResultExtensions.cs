using AE.Notice.Common.Application.Models;
using Microsoft.AspNetCore.Identity;

namespace AE.Notice.Common.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded 
            ? Result.Success() 
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
