using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Файловый_менеджер
{
    internal class SearchFiels
    {
        string _path;
        string _name;
        string[] _allFiles;

        public void SetPath(string path)
        {
            _path = path;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public string[] Getfiles()
        {
            try
            {
                _allFiles = Directory.GetFiles(_path, _name, SearchOption.AllDirectories);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            if(_allFiles.Length == 0)
            {
                _allFiles = new string[] {"Не найдено"};
            }
            return _allFiles;
        }


    }
}
