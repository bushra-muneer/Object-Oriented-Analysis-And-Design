using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrdering_ooad_.Entitty;
using System.Windows.Forms;
using System.IO;
using FoodOrdering_ooad_.DbServices;

namespace FoodOrdering_ooad_.Controller
{
    class manageitemController
    {
        manageitem manage = new manageitem();


        DBManue manue = new DBManue();
        public void InsertItem(string imgurl,ComboBox category,TextBox name,TextBox prie)
        {
            byte[] img = null;
            FileStream fs = new FileStream(imgurl, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            manage.InserItem(img,category,name,prie);
        }





        public void GetUpdate(int id,ComboBox cat,TextBox name,TextBox price,PictureBox pic)
        {
           
            manue.GetUpdate(id,cat,name,price,pic);
            
          
        
        }



        public void Update(string imgurl, ComboBox category, TextBox name, TextBox prie,int id)
        {
            byte[] img = null;
            FileStream fs = new FileStream(imgurl, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            manue.Update(img,category,name,prie,id);

        }

        public void Update(ComboBox category, TextBox name, TextBox prie, int id)
        {
            

            manue.Update(category, name, prie, id);

        }

        public void DeleteItem(int id)
        {
            manue.DeleteItem(id);
        
        }

        public void ShowItem(ListView lst)

        {
            lst.Items.Clear();
            manue.ShowItem(lst);
        
        }


        public void SearchItem(ComboBox cate,ListView lst)
        {
            string category = cate.Text.ToString();

            manue.SearchItem(category, lst);
        
        
        }



    
    }
}
