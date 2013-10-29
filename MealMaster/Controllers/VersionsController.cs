using System.IO;
using System.Web.Mvc;
using System.Xml.Serialization;
using MealMaster.Models;

namespace MealMaster.Controllers
{
    public class VersionsController : Controller
    {
        //
        // GET: /Versions/

        public ActionResult VersionNotes()
        {
            var path = Server.MapPath("~/VersionNotes.xml");

            var serializer = new XmlSerializer(typeof (VersionCollection));

            var reader = new StreamReader(path);

            var versions = (VersionCollection) serializer.Deserialize(reader);

            reader.Close();

            var versionList = versions.Version;

            return View(versionList);
        }

    }
}
