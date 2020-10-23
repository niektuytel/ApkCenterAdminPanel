

namespace AddApplication.Models
{
    public class CategoryModel
    {

        public string Globally { get; set; }
        public string Nederland { get; set; }

        public bool IsInvalid()
        {
            if( Globally is null )
                return true;
            else if(Nederland is null)
                return true;

            return false;
        }

    }
    
}
