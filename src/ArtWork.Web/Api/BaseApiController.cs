﻿using Microsoft.AspNetCore.Mvc;

namespace ArtWork.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
