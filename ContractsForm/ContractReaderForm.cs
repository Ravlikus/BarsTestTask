using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractsForm
{
    public partial class ContractReaderForm : Form
    {
        public ContractReaderForm()
        {
            InitializeComponent();
            ProcessServiceData();
        }

        private void ProcessServiceData()
        {
            try
            {
                var client = new ContractsService.ContractsServiceClient();
                var result = client.GetContracts();
                if (result != null)
                {
                    ContractsBS.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
