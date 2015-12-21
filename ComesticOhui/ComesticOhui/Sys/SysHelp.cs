using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace ComesticOhui.Sys
{
    public static class SysHelp
    {

        public static MvcHtmlString SysTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression,html.ViewData);
            // Create tag builder
            var builder = new TagBuilder("input");

            // Create valid id
            builder.GenerateId(metadata.PropertyName);

            // Add attributes
            builder.AddCssClass("form-control");
            string model = "";
            if (metadata.Model == null) model = ""; else model = metadata.Model.ToString();
            builder.MergeAttribute("value", model);

            // Render tag
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }

        public static MvcHtmlString SysCheckBoxList<TModel, TValue>(this HtmlHelper<TModel>html, Expression<Func<TModel, TValue>> expression)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);
            // Create tag builder
            var builder = new TagBuilder("input");

            // Create valid id
            builder.GenerateId(metadata.PropertyName);

            // Add attributes
            builder.AddCssClass("form-control");
            var obj = metadata.Model;

            // Render tag
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
        public static string Text(string text, object htmlAttributes)
        {
            // Create tag builder
            var builder = new TagBuilder("img");

            // Create valid id
            builder.GenerateId("thisid");

            // Add attributes
            builder.MergeAttribute("src", "thisurl");
            builder.MergeAttribute("alt", "thisalt");
            builder.MergeAttribute("class", "hello hello-word");
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // Render tag
            return builder.ToString(TagRenderMode.SelfClosing);
        }


        public static MvcHtmlString EditorFor(string text)
        {
            // Create tag builder
            var builder = new TagBuilder("input");

            // Create valid id
            builder.GenerateId("thisid");
            if (text == null) text = "";
            // Add attributes
            builder.MergeAttribute("src", "thisurl");
            builder.MergeAttribute("value", text);
            builder.MergeAttribute("alt", "thisalt");
            builder.MergeAttribute("class", "hello hello-word");
            //builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // Render tag
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }

    }
}