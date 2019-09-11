#pragma checksum "C:\Users\ruogu\source\repos\D3Test1\D3Test1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5a4a6e413cd8bae4d87ee3b0223772ec1000445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(D3Test1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(D3Test1.Pages.Pages_Index), null)]
namespace D3Test1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ruogu\source\repos\D3Test1\D3Test1\Pages\_ViewImports.cshtml"
using D3Test1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5a4a6e413cd8bae4d87ee3b0223772ec1000445", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21d9d7695223fc5b7129ded713bfd949d73a00a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ruogu\source\repos\D3Test1\D3Test1\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 3260, true);
            WriteLiteral(@"
<script src=""https://d3js.org/d3.v5.min.js""></script>

<div class=""pie""></div>

<script>
    //define data and color
    var data = [
        { ""name"": ""apple"", ""value"": 65 },
        { ""name"": ""peach"", ""value"": 34 },
        { ""name"": ""orange"", ""value"": 13 },
        { ""name"": ""grape"", ""value"": 25 }
    ];

    var width = 300,
        height = 300,
        radius = Math.min(width, height) / 2;

    var color = d3.scaleSequential()
        .domain([0, 100])
        .interpolator(d3.interpolateRainbow);

    //set up arcs and pie
    var arcs = d3.pie()
        .value(function (d) { return d.value; })(data);

    var arc = d3.arc()
        .outerRadius(radius - 10)
        .innerRadius(0);

    var labelArc = d3.arc()
        .outerRadius(radius - 80)
        .innerRadius(radius - 80);

    //draw the shape
    var svg = d3.select("".pie"")
        .append(""svg"")
          .attr(""width"", width)
          .attr(""height"", height)
        .append(""g"")
          .attr(""trans");
            WriteLiteral(@"form"", ""translate("" + width / 2 + "","" + height / 2 + "")"");

    var g = svg.selectAll(""arc"")
        .data(arcs)
        .enter().append(""g"")
        .attr(""class"", ""arc"");

    g.append(""path"")
        .attr(""d"", arc)
        .style(""fill"", function (d) { return color(d.data.value); });

    //labels
    g.append(""text"")
        .attr(""transform"", function (d) { return ""translate("" + labelArc.centroid(d) + "")""; })
        .text(function (d) { return d.data.name; })
        .style(""fill"", ""black"");

    function generateData(){
            var testdata = stream_layers(7,10+Math.random()*100,.1).map(function(data, i) {
                return {
                    key: 'Stream' + i,
                    values: data.map(function(a){a.y = a.y * (i <= 1 ? -1 : 1); return a})
                };
            });

            testdata[0].type = ""area""
            testdata[0].yAxis = 1
            testdata[1].type = ""area""
            testdata[1].yAxis = 1
            testdata[2].type = ""line""
        ");
            WriteLiteral(@"    testdata[2].yAxis = 1
            testdata[3].type = ""line""
            testdata[3].yAxis = 2
            testdata[4].type = ""bar""
            testdata[4].yAxis = 2
            testdata[5].type = ""bar""
            testdata[5].yAxis = 2
            testdata[6].type = ""bar""
            testdata[6].yAxis = 2

            return testdata;
    };

    function stream_layers(n, m, o) {
        if (arguments.length < 3) o = 0;
            function bump(a) {
                var x = 1 / (.1 + Math.random()),
                    y = 2 * Math.random() - .5,
                    z = 10 / (.1 + Math.random());
                for (var i = 0; i < m; i++) {
                    var w = (i / m - y) * z;
                    a[i] += x * Math.exp(-w * w);
                }
            }
            return d3.range(n).map(function() {
                var a = [], i;
                for (i = 0; i < m; i++) a[i] = o + o * Math.random();
                for (i = 0; i < 5; i++) bump(a);
                return a.map(stream_index);
 ");
            WriteLiteral("           });\n    };\n\n    function stream_index(d, i) {\n            return {x: i, y: Math.max(0, d)};\n    };\n\n    var chartData = generateData();\n\n    console.log(chartData);\r\n\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
