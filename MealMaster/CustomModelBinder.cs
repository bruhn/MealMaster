using System;
using System.Globalization;
using System.Web.Mvc;

namespace MealMaster
{
    public class CustomModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            object result = null;

            if (bindingContext.ModelType == typeof(decimal))
            {
                var modelName = bindingContext.ModelName;
                var attemptedValue = bindingContext.ValueProvider.GetValue(modelName).AttemptedValue;

                var wantedSeperator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
                var alternateSeperator = (wantedSeperator == "," ? "." : ",");

                if (attemptedValue.IndexOf(wantedSeperator) == -1 && attemptedValue.IndexOf(alternateSeperator) != -1)
                {
                    attemptedValue = attemptedValue.Replace(alternateSeperator, wantedSeperator);
                }

                try
                {
                    result = decimal.Parse(attemptedValue, NumberStyles.Any);
                }
                catch (FormatException e)
                {
                    bindingContext.ModelState.AddModelError(modelName, e);
                }
            }
            else
            {
                result = base.BindModel(controllerContext, bindingContext);
            }

            return result;
        }
    }
}