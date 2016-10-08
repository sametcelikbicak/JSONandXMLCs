using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

namespace JSONandXMLCs
{
    [WebService(Namespace = "http://sametcelikbicak.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class JSONandXML : System.Web.Services.WebService
    {
        [WebMethod]
        public Member[] GetTeamFromXML()
        {
            Team team = new Team();
            return team.GetTeamMembers();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetTeamFromJSON()
        {
            Team team = new Team();
            return new JavaScriptSerializer().Serialize(team.GetTeamMembers());
        }
    }
}
