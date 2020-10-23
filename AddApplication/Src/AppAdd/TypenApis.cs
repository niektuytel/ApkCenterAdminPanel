using AddApplication.Models;

namespace AddApplication.Src.AppAdd
{
    class TypenApis
    {

        public bool IsSelecting { get; set; }
        public bool IsEditing { get; set; }

        public TypenApis()
        { }

        public string[] ModelToString(ApiTypeModel[] apiTypes)
        {
            int length = 0;
            if (apiTypes != null) length = apiTypes.Length;

            string[] apis = new string[length];
            for (int i = 0; i < length; i++)
            {
                apis[i] = apiTypes[i].ApiName;
            }

            return apis;
        }

    }
}
