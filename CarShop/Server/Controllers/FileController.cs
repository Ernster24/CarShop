﻿using CarShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CarShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

        public FileController(IWebHostEnvironment env)
        {
            _env = env;

        }

        [HttpPost]
        public async Task<ActionResult<List<UploadResult>>> UploadFile(List<IFormFile> files)
        {
            List<UploadResult> uploadResults = new List<UploadResult>();

            foreach(var file in files)
            {
                var uploadResult = new UploadResult();
                string trustedFileNameForStorage;   // Random string file name
                var untrustedFileName = file.FileName;  // Actual file name of uploaded file
                uploadResult.FileName = untrustedFileName;
                var trustedFileNameForDisplay = WebUtility.HtmlEncode(untrustedFileName);

                trustedFileNameForStorage = Path.GetRandomFileName();   // Changes file name to a random string to prevent files being overwritten
                var path = Path.Combine(_env.ContentRootPath, "Uploads", trustedFileNameForStorage);

                await using FileStream fs = new(path, FileMode.Create);
                await file.CopyToAsync(fs);

                uploadResult.StoredFileName = trustedFileNameForStorage;
                uploadResults.Add(uploadResult);
            }

            return Ok(uploadResults);   // (God, 2020)
        }
    }
}
