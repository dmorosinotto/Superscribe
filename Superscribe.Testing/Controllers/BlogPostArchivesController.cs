﻿namespace Superscribe.Testing.Controllers
{
    using System.Web.Http;

    public class BlogPostArchivesController : ApiController
    {
        public string Get(int siteId)
        {
            return string.Format("Get_BlogPostArchives_{0}", siteId);
        }
    }
}
