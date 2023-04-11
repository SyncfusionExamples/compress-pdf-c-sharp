# 7 ways to compress PDF files using C# 

The [Syncfusion .NET PDF library](https://www.syncfusion.com/products/file-formats/pdf/) that can be used to optimize or compress your PDF documents and which supports the following optimizations:
* Shrinking all images 
* Optimizing fonts 
* Removing metadata 
* Optimizing page content 
* Disabling incremental updates 
* Removing or flattening form fields 
* Removing or flattening annotations 

This repository contains the example optimize PDF document with multiple ways. 

Sample name | Description
--- | ---
[Compress PDF]() | Demonstrates the optimization of an existing PDF document based on image quality, page content, metadata, annotation, form fields, incremental update and font to reduce the file size of the PDF document. 

## Reducing PDF file size by shrinking all images

Downsampling the images will decrease the number of pixels and is possibly the most effective way to reduce PDF file size. The user can control the PDF file size with respect to the quality of the image. 

```csharp 

//Create a new compression option object.
PdfCompressionOptions options = new PdfCompressionOptions();
options.CompressImages = true;
//Image quality is a percentage.
options.ImageQuality = 10;

``` 

## Reducing PDF file size by optimizing fonts

Remove the unused glyphs and unwanted font tables from the embedded fonts in a PDF document to make it smaller.

```csharp 

PdfCompressionOptions options = new PdfCompressionOptions();
options.OptimizeFont = true;

``` 

## Reducing PDF file size by removing metadata

Optimizing the page contents will remove unwanted commented lines, white spaces, convert end-of-line characters to spaces and compress all uncompressed contents.

```csharp 

PdfCompressionOptions options = new PdfCompressionOptions();
options.RemoveMetadata = true;

``` 

## Reducing PDF file size by optimizing page contents

Optimizing the page contents will remove unwanted commented lines, white spaces, convert end-of-line characters to spaces and compress all uncompressed contents.

```csharp 

PdfCompressionOptions options = new PdfCompressionOptions();
options.OptimizePageContents = true;

```

## Reducing PDF file size by disabling incremental updates

Disabling the incremental update will rewrite the entire file, which results in a smaller PDF.

```csharp 

//Load the existing PDF document.
PdfLoadedDocument loadedDocument = new PdfLoadedDocument(@"input.pdf");
//Restructure the complete document.
loadedDocument.FileStructure.IncrementalUpdate = false;

```

## Reducing PDF file size by removing form fields

Removing or flattening form fields can help reduce your file size. When form fields and their values are not necessary, they can be removed. When they are necessary but require no further editing, they can be flattened. Both of these actions will result in a reduced file size.

```csharp 

public void RemoveFormFields(PdfLoadedDocument ldoc, bool flatten)
{
    if (flatten)
    {
        ldoc.Form.Flatten = true;
    }
    else
    {
        int count = ldoc.Form.Fields.Count;
        for (int i = count - 1; i >= 0; i--)
        {
            ldoc.Form.Fields.RemoveAt(i);
        }
    }
}

```

## Reducing PDF file size by removing annotations

Removing or flattening annotations can help reduce your file size. 

```csharp 

public void RemoveAnnotations(PdfLoadedDocument ldoc, bool flatten)
{
    foreach(PdfPageBase page in ldoc.Pages)
    {
        if (flatten)
        {
           page.Annotations.Flatten = true;
        }
        else
        {
            int count = page.Annotations.Count;
            for (int i = count - 1;i >= 0; i--)
            {
              page.Annotations.RemoveAt(i);
            }
        }
    }  
}

```

# How to run the examples
* Download this project to a location in your disk. 
* Open the solution file using Visual Studio. 
* Rebuild the solution to install the required NuGet package. 
* Run the application.

# Resources
*   **Product page:** [Syncfusion PDF Framework](https://www.syncfusion.com/document-processing/pdf-framework/net)
*   **Documentation page:** [Syncfusion .NET PDF library](https://help.syncfusion.com/file-formats/pdf/overview)
*   **Online demo:** [Syncfusion .NET PDF library - Online demos](https://ej2.syncfusion.com/aspnetcore/PDF/CompressExistingPDF#/bootstrap5)
*   **Blog:** [Syncfusion .NET PDF library - Blog](https://www.syncfusion.com/blogs/category/pdf)
*   **Knowledge Base:** [Syncfusion .NET PDF library - Knowledge Base](https://www.syncfusion.com/kb/windowsforms/pdf)
*   **EBooks:** [Syncfusion .NET PDF library - EBooks](https://www.syncfusion.com/succinctly-free-ebooks)
*   **FAQ:** [Syncfusion .NET PDF library - FAQ](https://www.syncfusion.com/faq/)

# Support and feedback
*   For any other queries, reach our [Syncfusion support team](https://www.syncfusion.com/support/directtrac/incidents/newincident?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples).
*   Request new feature through [Syncfusion feedback portal](https://www.syncfusion.com/feedback?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples).

# License
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples). You can purchase a licnense [here](https://www.syncfusion.com/sales/products?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples).

# About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 26,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.

Today, we provide 1600+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [React](https://www.syncfusion.com/react-ui-components?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [WPF](https://www.syncfusion.com/wpf-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [WinUI(Preview)](https://www.syncfusion.com/winui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples) and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=github-docio-examples)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

