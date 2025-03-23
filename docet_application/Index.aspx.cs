using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Web;
using System.Web.Http.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace docet_application
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Policy_Search_Click(object sender, EventArgs e)
        {
            string policyNumber = Text1.Value;

            if (!string.IsNullOrEmpty(policyNumber) && select_project.SelectedIndex > 0)
            {
                string selectedProject = select_project.Value;
                string pdfFilePath = GetPdfFilePath(policyNumber, selectedProject);
                if (!string.IsNullOrEmpty(pdfFilePath))
                {
                    iframepdf.Attributes.Add("src",pdfFilePath);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "InputAlert", "alert('PDF file not found for the policy number!');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "InputAlert", "alert('Please select a project and Input a policy number!');", true);
            }
        }

        private string GetPdfFilePath(string policyNumber, string selectedProject )
        {
            string projectFolder = GetProjectFolder(selectedProject);

            if (projectFolder != null)
            {
                string pdfFileName = $"{policyNumber}.pdf";
                string pdfFilePath = Path.Combine(projectFolder, pdfFileName);

                if (File.Exists(pdfFilePath))
                {
                    var url = GetProjectFolder(selectedProject,1)+"/"+ pdfFileName;

                    return url;
                }
            }

            return null;
        }

        private string GetProjectFolder(string selectedProject,int Index=0)
        {
            switch (selectedProject)
            {
                case "Ekok":
                    if(Index==0)                    
                        return Server.MapPath("~/Docet/Ekok_Folder");
                    else 
                        return "../../Docet/Ekok_Folder"; 
                case "Islami":
                    if (Index == 0)
                        return Server.MapPath("~/Docet/Islami_Folder");
                    else
                        return "../../Docet/Islami_Folder";
                case "Samajic":
                    if (Index == 0)
                        return Server.MapPath("~/Docet/Samajic_Folder");
                    else
                        return "../../Docet/Samajic_Folder";
                case "Khudro":
                    if (Index == 0)
                        return Server.MapPath("~/Docet/Khudro_Folder");
                    else
                        return "../../Docet/Khudro_Folder";
                case "Soria":
                    if (Index == 0)
                        return Server.MapPath("~/Docet/Soria_Folder");
                    else
                        return "../../Docet/Soria_Folder";
                case "Rupali":
                    if (Index == 0)
                        return Server.MapPath("~/Docet/Rupali_Folder");
                    else
                        return "../../Docet/Rupali_Folder";
                case "Alamanat":
                    if (Index == 0)
                        return Server.MapPath("~/Docet/Alamanat_Folder");
                    else
                        return "../../Docet/Alamanat_Folder";
                default:
                    return null;
            }
        }
    }
}
