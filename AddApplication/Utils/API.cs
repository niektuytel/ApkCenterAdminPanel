using System;
using System.Collections.Generic;
using System.Text;


namespace AddApplication.Utils
{
    class API
    {

#if true
        public const string IpAddress = "http://192.168.2.7:2000";
#else
        public const string IpAddress = "http://85.214.165.155:2000";
#endif

        public const string PathRequests = "/admin/apkcenter/request";
        public const string PathRequestRemove = "/admin/apkcenter/request/remove";

        public const string PathErrors = "/admin/apkcenter/errors";
        public const string PathErrorRemove = "/admin/apkcenter/error/remove";

        public const string PathAppAdd = "/admin/apkcenter/app/add/";
        public const string PathAppRemove = "/admin/apkcenter/app/remove";

        public const string PathCategoryAdd = "/admin/apkcenter/category/add";
        public const string PathCategoryEdit = "/admin/apkcenter/category/edit";
        public const string PathCategoryRemove = "/admin/apkcenter/category/remove";
        public const string PathCategories = "/admin/apkcenter/categories";

        public const string PathCountries = "/admin/apkcenter/countries";

    }
}
