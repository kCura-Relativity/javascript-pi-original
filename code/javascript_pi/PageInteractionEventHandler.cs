using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kCura.EventHandler;

namespace javascript_pi
{
    [kCura.EventHandler.CustomAttributes.Description("Page Interaction EventHandler")]
    [System.Runtime.InteropServices.Guid("249dfe75-7205-4c53-a93c-37806fe7aede")]
    public class PageInteractionEventhandler : kCura.EventHandler.PageInteractionEventHandler
    {
        public override Response PopulateScriptBlocks()
        {


            //Create a response object with default values
            kCura.EventHandler.Response retVal = new kCura.EventHandler.Response();
            retVal.Success = true;
            retVal.Message = String.Empty;

            string registerEventsScript = @"
                <script type=""text/javascript"">
                    function setDecisionDisplay(){
                        //could make this global so you don't have to type name twice, but should stay away from variables with global scope because it could cause ugly problems down the road.
                        var decision_dropdown = $(""#_dynamicTemplate__dynamicViewFieldRenderer_ctl02_dropDownList"");
                        var a_label = $(""#_dynamicTemplate__dynamicViewFieldRenderer_ctl03_nameCell"");
                        var a_textbox = $(""input[name='_dynamicTemplate$_dynamicViewFieldRenderer$ctl03$textBox$textBox']"");
                        var b_label = $(""#_dynamicTemplate__dynamicViewFieldRenderer_ctl04_nameCell"");
                        var b_textbox = $(""input[name='_dynamicTemplate$_dynamicViewFieldRenderer$ctl04$textBox$textBox']"");
                        
                        var selectedText = decision_dropdown.find("":selected"").text();

                        if (selectedText == ""A"")
                        {          
                            a_textbox.show();
                            a_label.show();
                            b_textbox.hide();
                            b_label.hide();
                        }
                        else if (selectedText == ""B"")
                        {
                            b_textbox.show();
                            b_label.show();
                            a_textbox.hide();
                            a_label.hide();
                        }
                        else
                        {
                            a_textbox.show();
                            a_label.show();
                            b_textbox.show();
                            b_label.show();
                        }

                    }

                    $(document).ready(
                        function() {
                            $('#_dynamicTemplate__dynamicViewFieldRenderer_ctl02_dropDownList').change(setDecisionDisplay);
                        }
                    )
                </script>
            ";




            if (this.PageMode == kCura.EventHandler.Helper.PageMode.Edit)
            {
                this.RegisterStartupScriptBlock(new kCura.EventHandler.ScriptBlock() { Key = "registerEventsScript", Script = registerEventsScript });
            }

            return retVal; 
        }
    }
}
