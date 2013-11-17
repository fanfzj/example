using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;


//5-1-a-s-p-x
public partial class Student_text : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=xTest;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_schoose ", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string sqlSChoose = "select * from tb_schoose order by ID desc";
                BaseClass.BindDG(GridView1, "ID", sqlSChoose, "tb_schoose");
                //int SChooseNum = Int32.Parse(sdr["SChooseNum"].ToString());
                //int SChoosePoint = Int32.Parse(sdr["SChoosePoint"].ToString());
                ////int MChooseNum = Int32.Parse(sdr["MChooseNum"].ToString());
                ////int MChoosePoint = Int32.Parse(sdr["MChoosePoint"].ToString());
                //int JudgeNum = Int32.Parse(sdr["JudgeNum"].ToString());
                //int JudgePoint = Int32.Parse(sdr["JudgePoint"].ToString());
                //int ApplicationNum = Int32.Parse(sdr["ApplicationNum"].ToString());
                //int InputNum = Int32.Parse(sdr["InputNum"].ToString());
                // string sqlSChoose = "select top " + SChooseNum + " * from tb_schoose order by newid()";
                // //string sqlMChoose = "select top " + MChooseNum + " * from tb_mchoose order by newid()";
                // string sqlJudge = "select top " + JudgeNum + " * from tb_judge order by newid()";
                // string sqlInput = "select top " + InputNum + " * from tb_input order by newid()";
                // string sqlApplication = "select top " + ApplicationNum + " * from tb_application order by newid()";
                // BaseClass.BindDG(GridView1, "ID", sqlSChoose, "tb_schoose");

                // BaseClass.BindDG(GridView2, "ID", sqlJudge, "tb_judge");
                // BaseClass.BindDG(GridView3, "ID", sqlInput, "tb_input");
                // BaseClass.BindDG(GridView4, "ID", sqlApplication, "tb_application");
            }
            conn.Close();
            conn.Open();
            SqlCommand cmdjudge = new SqlCommand("select * from tb_judge", conn);
            SqlDataReader sdrjudge = cmdjudge.ExecuteReader();
            while (sdrjudge.Read())
            {
                string strjudge = "select * from tb_judge";
                BaseClass.BindDG(GridView2, "ID", strjudge, "tb_judge");

            }
            conn.Close();
            conn.Open();
            SqlCommand cmdinput = new SqlCommand("select * from tb_input", conn);
            SqlDataReader sdrinput = cmdinput.ExecuteReader();
            while (sdrinput.Read())
            {
                string strinput = "select * from tb_input";
                BaseClass.BindDG(GridView3, "ID", strinput, "tb_input");
            }
            conn.Close();
            conn.Open();
            SqlCommand cmdquestion = new SqlCommand("select * from tb_application",conn);
            SqlDataReader sdrquestion = cmdquestion.ExecuteReader();
            while (sdrquestion.Read())
            {
                string strquestion = "select * from tb_application";
                BaseClass.BindDG(GridView4, "ID", strquestion, "tb_input");
            }
            conn.Close();
        }
        }

    protected void  btnjj_Click(object sender, EventArgs e)
    {
        string sql = "select answer from tb_schoose ";
                    SqlDataAdapter dataAdapter=new SqlDataAdapter(sql,conn);
                    DataSet dataset=new DataSet();
                    dataAdapter.Fill(dataset,"tb_schoose");
                    DataTable datatable = dataset.Tables["tb_schoose"];
                    int c = 0;//存答正确答案
                for (int a = 0; a < GridView1.Rows.Count; a++)
                {

                   RadioButtonList rbl = (RadioButtonList)(GridView1.Rows[a].FindControl("rbanswer"));//取用户所选答案
                   Label lblc = (Label)(GridView1.Rows[a].FindControl("lblc"));
                    if (rbl != null && rbl.SelectedValue != "")
                    {

                  string answer =datatable.Rows[a]["answer"].ToString().Trim();//取正确答案

                    if (rbl.SelectedValue.ToString().Trim() == answer)//比较
                    {
                        c = c + 1;
                        lblc.Text = "回答正确";
                    }
                    else
                    {
                        lblc.Text = "回答错";
                    }
                    }

                }
                btnjj.Enabled = false;//交完一次就不能在交
                string sdrsql = "select answer from tb_judge ";
                SqlDataAdapter da = new SqlDataAdapter(sdrsql, conn);
                DataSet ds = new DataSet();
                da.Fill(dataset, "tb_judge");
                DataTable dt = dataset.Tables["tb_judge"];
                int n = 0;//存答正确答案
                for (int a = 0; a < GridView1.Rows.Count; a++)
                {

                    RadioButtonList rbl = (RadioButtonList)(GridView1.Rows[a].FindControl("rbanswer"));//取用户所选答案
                    Label lblc = (Label)(GridView1.Rows[a].FindControl("lblc"));
                    if (rbl != null && rbl.SelectedValue != "")
                    {

                        string answer = datatable.Rows[a]["answer"].ToString().Trim();//取正确答案

                        if (rbl.SelectedValue.ToString().Trim() == answer)//比较
                        {
                            n = n + 1;
                            lblc.Text = "回答正确";
                        }
                        else
                        {
                            lblc.Text = "回答错";
                        }
                    }

                }
                btnjj.Enabled = false;//交完一次就不能在交
                Response.Write("<script>alert('一共" + "  回答正确  " + "题你答对了" + c + "题');</script>");

            }
    protected void btnstart_Click(object sender, EventArgs e)
    {
      
        btnstart.Enabled = false;
        btnSchoose.Enabled = true;
        
        btnJudge.Enabled = true;
        btnInput.Enabled = true;
        btnApplication.Enabled = true;
        btnAll.Enabled = true;
        btnjj.Enabled = true;
    }
    protected void btnSchoose_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
      
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
    }
   
    protected void btnJudge_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
     
        Panel2.Visible = true;
        Panel3.Visible = false;
        Panel4.Visible = false;
    }
    protected void btnInput_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
       
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
    }
    protected void btnApplication_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
     
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = true;
    }
    protected void btnAll_Click(object sender, EventArgs e)
    {
        Panel1 .Visible = true;
      
        Panel2.Visible = true;
        Panel3.Visible = true;
        Panel4.Visible = true;
    }
}



   
