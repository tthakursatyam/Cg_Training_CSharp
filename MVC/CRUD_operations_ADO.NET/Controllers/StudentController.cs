using CRUD_operations_ADO.NET.Data;
using CRUD_operations_ADO.NET.Models;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Mvc;
using System.IO;
namespace CRUD_operations_ADO.NET.Controllers
{
    public class StudentController : Controller
    {

        private readonly StudentRead _studentRead;
        private readonly StudentCreate _studentCreate;
        private readonly StudentUpdate _studentUpdate;
        private readonly StudentDelete _studentDelete;

        public StudentController(StudentRead studentRead, StudentCreate studentCreate,StudentUpdate studentUpdate,StudentDelete studentDelete)
        {
            _studentRead = studentRead;
            _studentCreate = studentCreate;
            _studentUpdate = studentUpdate;
            _studentDelete = studentDelete;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetStudentData()
        {
            var students = _studentRead.GetAllStudentsDetails();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentInfo student, IFormFile ImageFile)
        {
            if (ImageFile != null && ImageFile.Length > 0)
            {
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".webp",".avif" };
                if (ImageFile != null)
                {
                    string extension = Path.GetExtension(ImageFile.FileName).ToLower();

                    if (!allowedExtensions.Contains(extension))
                    {
                        ModelState.AddModelError("", "Only image files are allowed.");
                        return View(student);
                    }
                }

                long maxSize = 2 * 1024 * 1024;

                if (ImageFile.Length > maxSize)
                {
                    ModelState.AddModelError("", "Image size must be less than 2MB.");
                    return View(student);
                }
                string folder = Path.Combine(Directory.GetCurrentDirectory(),
                                             "wwwroot/images/students");

                string fileName = Guid.NewGuid().ToString() +
                                  Path.GetExtension(ImageFile.FileName);

                string filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(stream);
                }

                student.ImagePath = "/images/students/" + fileName;
            }

            _studentCreate.AddStudent(student);

            return RedirectToAction("GetStudentData");
        }
        public IActionResult Update(int id)
        {
            var student = _studentRead.GetAllStudentsDetails().FirstOrDefault(x => x.Id == id);

            return View(student);
        }
        [HttpPost]
        public IActionResult UpdateStu(StudentInfo student, IFormFile ImageFile)
        {
            if (ImageFile != null && ImageFile.Length > 0)
            {
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".webp", ".avif" };

                string extension = Path.GetExtension(ImageFile.FileName).ToLower();

                if (!allowedExtensions.Contains(extension))
                {
                    ModelState.AddModelError("", "Only image files allowed");
                    return View("Update", student);
                }

                string folder = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot/images/students");

                string fileName = Guid.NewGuid().ToString() + extension;

                string filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(stream);
                }

                student.ImagePath = "/images/students/" + fileName;
            }

            _studentUpdate.UpdateStudent(student);

            return RedirectToAction("GetStudentData");
        }
        public IActionResult DeleteAll()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteAllConfirmed()
        {
            _studentDelete.DeleteAllStudents();

            return RedirectToAction("GetStudentData", "Student");
        }

        public IActionResult GeneratePdf()
        {
            var students = _studentRead.GetAllStudentsDetails();

            using (MemoryStream stream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(stream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                document.Add(new Paragraph("Student Report"));

                foreach (var s in students)
                {
                    document.Add(new Paragraph($"Name: {s.Name}"));
                    document.Add(new Paragraph($"Father Name: {s.Fathername}"));
                    document.Add(new Paragraph($"Email: {s.Email}"));
                    document.Add(new Paragraph($"Mobile: {s.Number}"));

                    if (!string.IsNullOrEmpty(s.ImagePath))
                    {
                        string imagePath = Path.Combine(
                            Directory.GetCurrentDirectory(),
                            "wwwroot",
                            s.ImagePath.TrimStart('/')
                        );

                        if (System.IO.File.Exists(imagePath))
                        {
                            var img = new iText.Layout.Element.Image(
                                iText.IO.Image.ImageDataFactory.Create(imagePath)
                            ).ScaleToFit(100, 100);

                            document.Add(img);
                        }
                    }

                    document.Add(new Paragraph("-----------------------"));
                }

                document.Close();

                byte[] bytes = stream.ToArray();

                return File(bytes,
                    "application/pdf",
                    "StudentsReport.pdf");
            }
        }

        public IActionResult GenerateIdCard(int id)
        {
            var student = _studentRead
                .GetAllStudentsDetails()
                .FirstOrDefault(x => x.Id == id);

            if (student == null)
                return NotFound();

            using (MemoryStream stream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(stream);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                document.SetMargins(20, 20, 20, 20);

                // Card Border
                Table card = new Table(1)
                    .SetWidth(250)
                    .SetHorizontalAlignment(HorizontalAlignment.CENTER);

                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                card.AddCell(new Cell()
                    .Add(new Paragraph("STUDENT ID CARD")
                    .SetFont(boldFont)
                    .SetFontSize(14)
                    .SetTextAlignment(TextAlignment.CENTER)));

                // Image
                if (!string.IsNullOrEmpty(student.ImagePath))
                {
                    string imagePath = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot",
                        student.ImagePath.TrimStart('/')
                    );

                    if (System.IO.File.Exists(imagePath))
                    {
                        var img = new Image(
                            iText.IO.Image.ImageDataFactory.Create(imagePath))
                            .ScaleToFit(100, 100)
                            .SetHorizontalAlignment(HorizontalAlignment.CENTER);

                        card.AddCell(new Cell().Add(img));
                    }
                }

                card.AddCell(new Cell().Add(new Paragraph($"Name : {student.Name}")));
                card.AddCell(new Cell().Add(new Paragraph($"City : {student.City}")));
                card.AddCell(new Cell().Add(new Paragraph($"Email : {student.Email}")));
                card.AddCell(new Cell().Add(new Paragraph($"Phone : {student.Number}")));

                document.Add(card);

                document.Close();

                byte[] bytes = stream.ToArray();

                return File(bytes,
                    "application/pdf",
                    $"IDCard_{student.Name}.pdf");
            }
        }
    }
}
