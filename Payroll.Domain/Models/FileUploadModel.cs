using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Management.BatchAI.Fluent.Models;

namespace Payroll.Domain.Models
{
    public class FileUploadModel
    {
        public IFormFile FileDetails { get; set; }
    }
}
