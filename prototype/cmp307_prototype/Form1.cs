using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace cmp307_prototype
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      devNameTxt.Text = purchaseDate.Text;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      purchaseDate.CustomFormat = " ";
      purchaseDate.Format = DateTimePickerFormat.Custom;

      DBConnection db = new DBConnection();
      db.ConnectDB();
    }

    private void purchaseDate_ValueChanged(object sender, EventArgs e)
    {
      purchaseDate.CustomFormat = "dd/MM/yyyy";
    }
  }
}
