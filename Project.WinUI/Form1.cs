using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        CategoryRepository _cRep;
        public Form1()
        {
            InitializeComponent();
            _cRep = new CategoryRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category c = new Category
            {
                CategoryName = txtIsim.Text,
                Description = txtAciklama.Text
            };
            _cRep.Add(c);
            lstResult.DataSource = _cRep.GetActives();
        }
    }
}
