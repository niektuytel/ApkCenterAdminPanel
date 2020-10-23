using System.Threading.Tasks;
using AddApplication.Models;
using AddApplication.Src.AllForms;

namespace AddApplication.Src.AppAdd
{
    class AutoFill
    {
        private readonly FormAppAdd _formAppAdd;
        private readonly AppSuggestedModel _suggested;
        private readonly AutoFillWebsite _autoFillWebsite;
        private readonly AutoFillApk _autoFillApk;

        public AutoFill(FormAppAdd formAppAdd)
        {
            _formAppAdd = formAppAdd;
            _suggested = new AppSuggestedModel();
            _autoFillApk = new AutoFillApk(_suggested);
            _autoFillWebsite = new AutoFillWebsite(_suggested);
        }

        /// <summary>
        /// search for so much as possible usefull information (async), Update Application and Phone Interface
        /// </summary>
        /// <param name="value">value textbox</param>
        /// <param name="name">id textbox</param>
        public async Task SearchAllAsync(string value, string name)
        {
            bool hasInfo = false;

            if (name.ToLower().Contains("website"))
            {
                hasInfo = await Task.Run( 
                    () => _autoFillWebsite.HasInfo(value) 
                );
            }
            else if(name.ToLower().Contains("apk"))
            {
                hasInfo = await Task.Run( 
                    () => _autoFillApk.HasInfo(value) 
                );
            }

            if (hasInfo)
            {
                _formAppAdd.RefreshUI();
            }
        }
    }
}
