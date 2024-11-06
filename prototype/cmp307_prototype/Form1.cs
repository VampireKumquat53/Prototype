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
      try
      {
        if (devNameTxt.Text == "" || modelTxt.Text == "" || manuTxt.Text == "" || typeTxt.Text == "" || ipTxt.Text == "")
        {
          throw new Exception("Required fields must not be empty");
        }

        Asset asset = new Asset()
        {
          deviceName = devNameTxt.Text,
          model = modelTxt.Text,
          manufacturer = manuTxt.Text,
          type = typeTxt.Text,
          ipAddress = ipTxt.Text,
          purchaseDate = purchaseDate.Value,
          note = noteTxt.Text
        };

        asset.addAsset(asset);
        Console.WriteLine("added asset");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      purchaseDate.CustomFormat = " ";
      purchaseDate.Format = DateTimePickerFormat.Custom;
    }

    private void purchaseDate_ValueChanged(object sender, EventArgs e)
    {
      purchaseDate.CustomFormat = "dd/MM/yyyy";
    }
  }
}
