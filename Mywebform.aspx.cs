using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_CURD3
{
    public partial class Mywebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();
            }
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2RLTC1M;Initial Catalog=EmployeeDB;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd=new SqlCommand("Insert into Employee_table values('"+int.Parse(TextBox1.Text)+"','"+TextBox2.Text+"','"+int.Parse(TextBox3.Text)+"','"+DropDownList1.SelectedValue+"')",con);
            //Response.Write("<script>alert('Insteted Successfully');</script>");
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.ForeColor = System.Drawing.Color.Green;
            Label1.Text = "Inserted Successfully";
            //System.Threading.Thread.Sleep(5000);
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            LoadData();
            //this.Label3.Visible = true;
            
        }
        void LoadData()
        {
            SqlCommand cmd = new SqlCommand("select * from Employee_table", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            //GridView1.Enabled=false;

        }
        void LoadData1()
        {
            SqlCommand cmd = new SqlCommand("select * from Employee_table where EmpId='" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataAdapter d1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            GridView2.DataSource = dt1;
            GridView2.DataBind();
            //GridView1.Enabled = false;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Employee_table set Empname='"+TextBox2.Text+"',Empage='"+int.Parse(TextBox3.Text)+"',EmpAddress='"+DropDownList1.SelectedValue+"' where EmpId='"+int.Parse(TextBox1.Text)+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label2.ForeColor = System.Drawing.Color.Green;
            //Response.Write("<script>alert('Data inserted successfully')</script>");
            Label2.Text = "Updated Successfully";
            //TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            LoadData();
            //GridView1.Enabled = true;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Employee_table where EmpId='"+int.Parse(TextBox1.Text)+ "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label3.ForeColor = System.Drawing.Color.Red;
            //Response.Write("<script>alert('Data inserted successfully')</script>");
            Label3.Text = "Deleted Successfully";
            //TextBox1.Text = "";
            //TextBox2.Text = "";
            //TextBox3.Text = "";
            LoadData();
            GridView1.Enabled = true;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  Employee_table where EmpId='" + int.Parse(TextBox1.Text) + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label4.ForeColor = System.Drawing.Color.Green;
            //Response.Write("<script>alert('Data inserted successfully')</script>");
            Label3.Text = "Fetched Successfully";
            
            //TextBox1.Text = "";
            //TextBox2.Text = "";
            //TextBox3.Text = "";
            LoadData1();
            //GridView1.Enabled = true;

        }
    }
}