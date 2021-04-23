using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WebApplication9
{
    
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }


        }
        public void BindGrid()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from tblQuestions", @"Data Source=LAPTOP-A1FD4L6K\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True");
            adp.Fill(dt);
            grdquestions.DataSource = dt;
            grdquestions.DataBind();
        }


        protected void grdquestions_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                RadioButtonList rdlstOptions = (RadioButtonList)e.Row.FindControl("rdlstOptions");
                HiddenField hdnquestionId = (HiddenField)e.Row.FindControl("hdnquestionId");
                if (rdlstOptions != null && hdnquestionId != null)
                {
                    DataRow[] result = dt.Select("questionid=" + (Convert.ToInt32(hdnquestionId.Value)));
                    DataView view = new DataView();
                    view.Table = dt;
                    view.RowFilter = "questionid=" + (Convert.ToInt32(hdnquestionId.Value));
                    if (view.Table.Rows.Count > 0)
                    {
                        DataTable dt1 = new DataTable();
                        dt1 = view.ToTable();
                    }
                }
            }


        }
    }
}