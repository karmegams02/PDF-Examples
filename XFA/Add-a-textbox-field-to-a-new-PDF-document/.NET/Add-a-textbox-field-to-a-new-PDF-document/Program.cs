﻿// See https://aka.ms/new-console-template for more information

using Syncfusion.Drawing;
using Syncfusion.Pdf.Xfa;

//Create a new PDF XFA document.
PdfXfaDocument document = new PdfXfaDocument();

//Add a new XFA page.
PdfXfaPage xfaPage = document.Pages.Add();

//Create a new PDF XFA form.
PdfXfaForm mainForm = new PdfXfaForm("subform1", xfaPage, xfaPage.GetClientSize().Width);

//Create a textbox field and add the properties.
PdfXfaTextBoxField textBoxField = new PdfXfaTextBoxField("FirstName", new SizeF(200, 20));

//Set the caption text.
textBoxField.Caption.Text = "First Name";

//Set the tool tip.
textBoxField.ToolTip = "First Name";

//Add the field to the XFA form.
mainForm.Fields.Add(textBoxField);

//Add the XFA form to the document.
document.XfaForm = mainForm;

//Create file stream.
using (FileStream outputFileStream = new FileStream(Path.GetFullPath(@"../../../Output.pdf"), FileMode.Create, FileAccess.ReadWrite))
{
    //Save the PDF document to file stream.
    document.Save(outputFileStream, PdfXfaType.Dynamic);
}

//Close the document.
document.Close();

