﻿using NhibernateCRUD.Models;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace NhibernateCRUD
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RadGrid1.Rebind();
            }
            ScriptManager.RegisterStartupScript(this, GetType(), "AttachContextMenuScript", "AttachContextMenu();", true);
        }

        protected void RadGrid1_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            RadGrid1.DataSource = GetEmployees();
        }

        protected void RadGrid1_InsertCommand(object sender, GridCommandEventArgs e)
        {
            if (e.Item is GridEditableItem editableItem)
            {
                string firstName = (editableItem.FindControl("txtFirstName") as TextBox).Text;
                string lastName = (editableItem.FindControl("txtLastName") as TextBox).Text;
                string designation = (editableItem.FindControl("txtDesignation") as TextBox).Text;

                using (var session = ConnectionNhibernate.OpenSession())
                {
                    var newEmployee = new Employee
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Designation = designation
                    };

                    using (var transaction = session.BeginTransaction())
                    {
                        session.Save(newEmployee);
                        transaction.Commit();
                    }
                }
            }

            RadGrid1.Rebind();
        }

<<<<<<< HEAD
        protected void btnSearch_Click(object sender, EventArgs e)
=======
<<<<<<< HEAD
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Value.Trim(); 
=======
      /*  protected void btnSearch_Click(object sender, EventArgs e)
>>>>>>> 4402f55b26d733c5c99a7ce3ae120f2941212c01
        {
            string searchTerm = txtSearch.Value.Trim();
>>>>>>> 010a0e41e4817fb44f685276db1326cf8de140bb

            if (!string.IsNullOrEmpty(searchTerm))
            {
                using (var session = ConnectionNhibernate.OpenSession())
                {
                    var employees = session.Query<Employee>()
                        .Where(emp => emp.FirstName.Contains(searchTerm) || emp.LastName.Contains(searchTerm) || emp.Designation.Contains(searchTerm))
                        .ToList();

                    RadGrid1.DataSource = employees;
                    RadGrid1.Rebind();
                }
            }
            else
            {
<<<<<<< HEAD
              
                RadGrid1.Rebind();
            }
        }

=======

                RadGrid1.Rebind();
            }
        }
<<<<<<< HEAD

=======
*/
>>>>>>> 010a0e41e4817fb44f685276db1326cf8de140bb
>>>>>>> 4402f55b26d733c5c99a7ce3ae120f2941212c01


        protected void RadGrid1_UpdateCommand(object sender, GridCommandEventArgs e)
        {
            EmployeeManager.UpdateEmployee(e.Item as GridEditableItem);
            RadGrid1.Rebind();
        }

        protected void RadGrid1_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            EmployeeManager.DeleteEmployee(e);
            RadGrid1.Rebind();
        }




        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddItem.aspx");
        }


        private object GetEmployees()
        {
            using (var session = ConnectionNhibernate.OpenSession())
            {
                var employees = session.Query<Employee>().ToList();
                return employees;
            }
        }
       
    }
}








   