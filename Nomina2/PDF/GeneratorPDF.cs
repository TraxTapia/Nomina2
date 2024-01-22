//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using MAC.Framework.Generic.BarCode;
//using MAC.Framework.WebApiSASE.Repository;
//using MAC.Models.WebApiSASE.BaseMaedicusCPT;
//using MAC.Models.WebApiSASE.Binding;
//using MAC.Models.WebApiSASE.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
namespace Nomina2.PDF
{

    public class GeneratorPDF
    {
        //public void GeneratePDFDetails(string PathFile, string NameProvider, List<ValidatedFiles> Data)
        //{
        //    Document _Document = new Document(PageSize.A4, 40, 40, 20, 40);
        //    if (string.IsNullOrEmpty(PathFile) || string.IsNullOrEmpty(NameProvider) || !(Data != null && Data.Count > 0))
        //        throw new Exception("Parámetros de entrada inválidos.");
        //    try
        //    {
        //        PdfWriter _PdfWriter = PdfWriter.GetInstance(_Document, new FileStream(PathFile, FileMode.Create));
        //        _Document.Open();
        //        _Document.Add(new Phrase(" "));
        //        int _index = 0;
        //        foreach (var item in Data)
        //        {
        //            if (_index > 0 && (_index % 3) == 0)
        //            {
        //                _Document.NewPage();
        //                _Document.Add(new Phrase(" "));
        //            }
        //            PdfPTable _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90,
        //                HorizontalAlignment = Element.ALIGN_CENTER
        //            };
        //            Int32[] widhtColsH = new Int32[] { 30, 70 };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            Font NormalMenu = FontFactory.GetFont(FontFactory.COURIER, 9, Font.NORMAL, BaseColor.WHITE);

        //            string _NameFile = item.Archivo.Split('_').ToList().FirstOrDefault() + Path.GetExtension(item.Archivo);
        //            PdfPCell _CellNameFile = new PdfPCell(new Phrase(_NameFile, NormalMenu))
        //            {
        //                BackgroundColor = BaseColor.GRAY,
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);
        //            NormalMenu = FontFactory.GetFont(FontFactory.COURIER, 9, Font.NORMAL, BaseColor.BLACK);
        //            Font BoldMenu = FontFactory.GetFont(FontFactory.COURIER, 9, Font.BOLD, BaseColor.BLACK);
        //            //NameProvider
        //            _PdfPTable = new PdfPTable(2)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(widhtColsH);
        //            //PdfPCell _CellIndex = new PdfPCell(new Phrase("Nombre : ", NormalMenu))
        //            PdfPCell _CellIndex = new PdfPCell(new Phrase("", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 0,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 1,
        //                BorderWidthBottom = 0
        //            };
        //            _CellNameFile = new PdfPCell(new Phrase(NameProvider, BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 1,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 0,
        //                BorderWidthBottom = 0
        //            };
        //            _PdfPTable.AddCell(_CellIndex);
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //CodeProvider
        //            _PdfPTable = new PdfPTable(2)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(widhtColsH);
        //            //_CellIndex = new PdfPCell(new Phrase("Proveedor : ", NormalMenu))
        //            _CellIndex = new PdfPCell(new Phrase("", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 0,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 1,
        //                BorderWidthBottom = 0
        //            };
        //            _CellNameFile = new PdfPCell(new Phrase(item.Usuario_Carga, BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 1,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 0,
        //                BorderWidthBottom = 0
        //            };
        //            _PdfPTable.AddCell(_CellIndex);
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //Number of Register
        //_PdfPTable = new PdfPTable(2)
        //{
        //    WidthPercentage = 80
        //};
        //_PdfPTable.SetWidths(widhtColsH);
        //_CellIndex = new PdfPCell(new Phrase("Registros : ", NormalMenu))
        //{
        //    HorizontalAlignment = Element.ALIGN_LEFT,
        //    BorderColor = BaseColor.GRAY,
        //    BorderWidthRight = 0,
        //    BorderWidthTop = 0,
        //    BorderWidthLeft = 1,
        //    BorderWidthBottom = 0
        //};
        //_CellNameFile = new PdfPCell(new Phrase(item.Filas_Total.ToString(), BoldMenu))
        //{
        //    HorizontalAlignment = Element.ALIGN_LEFT,
        //    BorderColor = BaseColor.GRAY,
        //    BorderWidthRight = 1,
        //    BorderWidthTop = 0,
        //    BorderWidthLeft = 0,
        //    BorderWidthBottom = 0
        //};
        //_PdfPTable.AddCell(_CellIndex);
        //_PdfPTable.AddCell(_CellNameFile);
        //_Document.Add(_PdfPTable);

        //Amount
        //_PdfPTable = new PdfPTable(2)
        //{
        //    WidthPercentage = 80
        //};
        //_PdfPTable.SetWidths(widhtColsH);
        //_CellIndex = new PdfPCell(new Phrase("Monto : ", NormalMenu))
        //{
        //    HorizontalAlignment = Element.ALIGN_LEFT,
        //    BorderColor = BaseColor.GRAY,
        //    BorderWidthRight = 0,
        //    BorderWidthTop = 0,
        //    BorderWidthLeft = 1,
        //    BorderWidthBottom = 0
        //};
        //_CellNameFile = new PdfPCell(new Phrase(item.Total.ToString("C2"), BoldMenu))
        //{
        //    HorizontalAlignment = Element.ALIGN_LEFT,
        //    BorderColor = BaseColor.GRAY,
        //    BorderWidthRight = 1,
        //    BorderWidthTop = 0,
        //    BorderWidthLeft = 0,
        //    BorderWidthBottom = 0
        //};
        //_PdfPTable.AddCell(_CellIndex);
        //_PdfPTable.AddCell(_CellNameFile);
        //_Document.Add(_PdfPTable);

        //Remesa
        //            _PdfPTable = new PdfPTable(2)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(widhtColsH);
        //            //_CellIndex = new PdfPCell(new Phrase("Remesa : ", NormalMenu))
        //            _CellIndex = new PdfPCell(new Phrase("", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 0,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 1,
        //                BorderWidthBottom = 0
        //            };
        //            _CellNameFile = new PdfPCell(new Phrase(item.FolioVal.Substring(0, item.FolioVal.Length - 1), BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 1,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 0,
        //                BorderWidthBottom = 0
        //            };
        //            _PdfPTable.AddCell(_CellIndex);
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //BarCode
        //            GeneratorBarcode _GeneratorBarcode = new GeneratorBarcode();
        //            Image _Barcode = Image.GetInstance(_GeneratorBarcode.GenerateCodebar(item.FolioVal, 200, 75, false), BaseColor.WHITE);
        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(_Barcode)
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //Date
        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(new Phrase(item.Fecha.ToString(), BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //Register
        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(new Phrase("# Registros " + item.Filas_Total.ToString(), BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //Texto
        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(new Phrase("Revisión a cotejo de originales", BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(new Phrase("Vigencia para entrega de originales 30 días a partir de la fecha de generación.", BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            _PdfPTable = new PdfPTable(2)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(widhtColsH);
        //            _CellIndex = new PdfPCell(new Phrase(" ", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 0,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 1,
        //                BorderWidthBottom = 1
        //            };
        //            _CellNameFile = new PdfPCell(new Phrase(" ", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 1,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 0,
        //                BorderWidthBottom = 1
        //            };
        //            _PdfPTable.AddCell(_CellIndex);
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            _Document.Add(new Phrase(" "));
        //            _index++;
        //        }
        //    }
        //    finally
        //    {
        //        _Document.Close();
        //    }
        //}
        //public async Task GeneratePDFDetailsAsync(string PathFile, List<ValidatedFiles> Data)
        //{
        //    Document _Document = new Document(PageSize.A4, 40, 40, 20, 40);
        //    try
        //    {
        //        RepositoryValidator _Repository = new RepositoryValidator();
        //        PdfWriter _PdfWriter = PdfWriter.GetInstance(_Document, new FileStream(PathFile, FileMode.Create));
        //        _Document.Open();
        //        _Document.Add(new Phrase(" "));
        //        int _index = 0;
        //        foreach (var item in Data)
        //        {
        //            string _NameProvider = await _Repository.GetNameProviderByCodeAsync(Int32.Parse(item.CodeProvider));
        //            if (_index > 0 && ((_index % 3) == 0))
        //            {
        //                _Document.NewPage();
        //                _Document.Add(new Phrase(" "));
        //            }
        //            PdfPTable _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90,
        //                HorizontalAlignment = Element.ALIGN_CENTER
        //            };
        //            Int32[] widhtColsH = new Int32[] { 30, 70 };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            Font NormalMenu = FontFactory.GetFont(FontFactory.COURIER, 9, Font.NORMAL, BaseColor.WHITE);
        //            string _NameFile = item.Archivo.Split('_').ToList().FirstOrDefault() + Path.GetExtension(item.Archivo);
        //            PdfPCell _CellNameFile = new PdfPCell(new Phrase(_NameFile, NormalMenu))
        //            {
        //                BackgroundColor = BaseColor.GRAY,
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);
        //            NormalMenu = FontFactory.GetFont(FontFactory.COURIER, 9, Font.NORMAL, BaseColor.BLACK);
        //            Font BoldMenu = FontFactory.GetFont(FontFactory.COURIER, 9, Font.BOLD, BaseColor.BLACK);
        //            //NameProvider
        //            _PdfPTable = new PdfPTable(2)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(widhtColsH);

        //            PdfPCell _CellIndex = new PdfPCell(new Phrase("", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 0,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 1,
        //                BorderWidthBottom = 0
        //            };
        //            _CellNameFile = new PdfPCell(new Phrase(_NameProvider, BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 1,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 0,
        //                BorderWidthBottom = 0
        //            };
        //            _PdfPTable.AddCell(_CellIndex);
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //CodeProvider
        //            _PdfPTable = new PdfPTable(2)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(widhtColsH);
        //            _CellIndex = new PdfPCell(new Phrase("", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 0,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 1,
        //                BorderWidthBottom = 0
        //            };
        //            _CellNameFile = new PdfPCell(new Phrase(item.CodeProvider.TrimStart('0'), BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 1,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 0,
        //                BorderWidthBottom = 0
        //            };
        //            _PdfPTable.AddCell(_CellIndex);
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //Remesa
        //            _PdfPTable = new PdfPTable(2)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(widhtColsH);

        //            _CellIndex = new PdfPCell(new Phrase("", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 0,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 1,
        //                BorderWidthBottom = 0
        //            };
        //            _CellNameFile = new PdfPCell(new Phrase(item.FolioVal.Substring(0, item.FolioVal.Length - 1), BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 1,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 0,
        //                BorderWidthBottom = 0
        //            };
        //            _PdfPTable.AddCell(_CellIndex);
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //BarCode
        //            GeneratorBarcode _GeneratorBarcode = new GeneratorBarcode();
        //            Image _Barcode = Image.GetInstance(_GeneratorBarcode.GenerateCodebar(item.FolioVal, 200, 75, false), BaseColor.WHITE);
        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(_Barcode)
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //Date
        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(new Phrase(item.Fecha.ToString(), BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //Register
        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(new Phrase("# Registros " + item.Filas_Total.ToString(), BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            //Texto
        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(new Phrase("Revisión a cotejo de originales", BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            _PdfPTable = new PdfPTable(1)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(new[] { 100 });
        //            _CellNameFile = new PdfPCell(new Phrase("Vigencia para entrega de originales 30 días a partir de la fecha de generación.", BoldMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                Border = 0,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthLeft = 1,
        //                BorderWidthRight = 1
        //            };
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);

        //            _PdfPTable = new PdfPTable(2)
        //            {
        //                WidthPercentage = 90
        //            };
        //            _PdfPTable.SetWidths(widhtColsH);
        //            _CellIndex = new PdfPCell(new Phrase(" ", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_CENTER,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 0,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 1,
        //                BorderWidthBottom = 1
        //            };
        //            _CellNameFile = new PdfPCell(new Phrase(" ", NormalMenu))
        //            {
        //                HorizontalAlignment = Element.ALIGN_LEFT,
        //                BorderColor = BaseColor.GRAY,
        //                BorderWidthRight = 1,
        //                BorderWidthTop = 0,
        //                BorderWidthLeft = 0,
        //                BorderWidthBottom = 1
        //            };
        //            _PdfPTable.AddCell(_CellIndex);
        //            _PdfPTable.AddCell(_CellNameFile);
        //            _Document.Add(_PdfPTable);
        //            _Document.Add(new Phrase(" "));
        //            _index++;
        //        }
        //    }
        //    finally
        //    {
        //        _Document.Close();
        //    }
        //}
        //public async Task FillLetterLeftOversAsync(string PathTemplate, string PathFile, ValidatedFiles Data)
        //{
        //    RepositoryValidator _Repository = new RepositoryValidator();
        //    string _NameProvider = await _Repository.GetNameProviderByCodeAsync(Int32.Parse(Data.CodeProvider));
        //    string _Client = await _Repository.FindNameEnterpriseByKeyAsync(Data.cve_empresa);
        //    var _RejectedFolios = Data.ValidatedFileDetails.Where(x => x.ReasonRejectedFolio_Id != (int)EnumReasonRejectedFolio.OK).Select(x => new RejectedFolios()
        //    {
        //        Folio = x.folio,
        //        ReasonRejected = x.ReasonRejectedFolio.RequiredObservation ? x.Observation : x.ReasonRejectedFolio.Description.Replace("_", " ")
        //    }).ToList();
        //    if (!string.IsNullOrEmpty(Data.LeftOvers))
        //    {
        //        _RejectedFolios.AddRange(
        //            Data.LeftOvers.Split('#').ToList().Select(x => new RejectedFolios()
        //            {
        //                Folio = x.Trim(),
        //                ReasonRejected = "Folio sobrante no incluido en archivo de remesa"
        //            }).ToList());
        //    }
        //    int _Total = (int)Math.Ceiling(((decimal)_RejectedFolios.Count / (decimal)10));
        //    var _Document = new Document(PageSize.A4, 40, 40, 20, 40);
        //    using (var _MemoryTemp = new FileStream(PathFile, FileMode.Create))
        //    using (var _PdfCopy = new PdfCopy(_Document, _MemoryTemp))
        //    {
        //        _PdfCopy.CloseStream = false;
        //        _Document.Open();
        //        for (int i = 0; i < _Total; i++)
        //        {
        //            var _Grop = _RejectedFolios.Skip(i * 10).Take(10).ToList();
        //            using (var _FileStream = new FileStream(PathTemplate, FileMode.Open))
        //            using (var _MemoryStream = new MemoryStream())
        //            using (var _PdfReader = new PdfReader(_FileStream))
        //            using (var _PdfStamper = new PdfStamper(_PdfReader, _MemoryStream))
        //            {
        //                try
        //                {
        //                    var form = _PdfStamper.AcroFields;
        //                    form.SetField("(Fecha)", DateTime.Now.ToString("dd-MM-yyyy"));
        //                    form.SetField("(Numero_Proveedor)", Data.CodeProvider.TrimStart('0'));
        //                    form.SetField("(Nombre_Proveedor)", _NameProvider);
        //                    form.SetField("(Remesa)", Data.FolioVal.Substring(0, Data.FolioVal.Length - 1));
        //                    form.SetField("(Nombre_Cliente)", _Client);
        //                    form.SetField("(Usuario)", Data.Usuario_Carga);
        //                    int _Index = 0;
        //                    foreach (var item2 in _Grop)
        //                    {
        //                        _Index++;
        //                        form.SetField("Folio " + _Index.ToString(), item2.Folio);
        //                        string _ReasonRejected = item2.ReasonRejected.Length < 40 ? item2.ReasonRejected : string.Join("\n", item2.ReasonRejected.Split(' '));
        //                        form.SetField("Motivo " + _Index.ToString(), item2.ReasonRejected.Replace(".", "") + ".");
        //                    }
        //                    _PdfStamper.FormFlattening = true;
        //                }
        //                finally
        //                {
        //                    _PdfStamper.Close();
        //                    _PdfReader.Close();
        //                    _PdfCopy.AddPage(_PdfCopy.GetImportedPage(new PdfReader(_MemoryStream.ToArray()), _PdfReader.NumberOfPages));
        //                }
        //            }
        //        }
        //        _PdfCopy.Close();
        //        _Document.Close();
        //    }
        //}
    }
}


