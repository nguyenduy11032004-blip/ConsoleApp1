using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRevit_2
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
    ref string message, ElementSet elements)
        {
            UIDocument uiDocument = commandData.Application.ActiveUIDocument;
            Document document = uiDocument.Document;
            ICollection<ElementId> selectedIds = uiDocument.Selection.GetElementIds();

            if (selectedIds.Count == 0)
            {
                Autodesk.Revit.UI.TaskDialog.Show("Revit", "Hãy chọn các đối tượng trước khi chạy lệnh.");
                return Result.Cancelled;
            }

            List<ElementId> filteredIds = new List<ElementId>();
            ElementId structuralColumnCategoryId =
                new ElementId(BuiltInCategory.OST_StructuralColumns);

            int beamCount = 0;
            int columnCount = 0;
            int floorCount = 0;

            foreach (ElementId id in selectedIds)
            {
                Element element = document.GetElement(id);

                if (element is Floor)
                {
                    filteredIds.Add(id);
                    floorCount++;
                }
                else if (element is FamilyInstance familyInstance)
                {
                    if (familyInstance.StructuralType == StructuralType.Beam)
                    {
                        filteredIds.Add(id);
                        beamCount++;
                    }
                    else if (structuralColumnCategoryId.Equals(familyInstance.Category?.Id))
                    {
                        filteredIds.Add(id);
                        columnCount++;
                    }
                }
            }

            uiDocument.Selection.SetElementIds(filteredIds);

            Autodesk.Revit.UI.TaskDialog.Show("Revit",
                $"Số đối tượng ban đầu: {selectedIds.Count}\n" +
                $"Dầm: {beamCount}\n" +
                $"Cột kết cấu: {columnCount}\n" +
                $"Sàn: {floorCount}\n" +
                $"Tổng số đối tượng giữ lại: {filteredIds.Count}");

            return Result.Succeeded;
        }
    }
}
