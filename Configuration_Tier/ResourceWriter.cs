using Automation_Suite._02_Utility_Tier;
using System.Collections.Generic;
using System.Resources;

namespace Automation_Suite.Configuration_Tier
{
    class ResourceWriter
    {
        ResXResourceWriter resx = null;

        public void WriteResources( Dictionary<string, string> dynamicdata)
        {

            if (resx == null)
            {
                resx = new ResXResourceWriter(@"C:\Pobal_AutomationProject\Pobal_Test_Project\Automation_Suite\Configuration_Tier\Dynamic_Data_Write.resx");
            }
                string value = "";
               
                    foreach(var element in dynamicdata)
                    {
                        resx.AddResource(element.Key, element.Value);
                    }

                    
                    
                    resx.Close();
                }

            }
        }



 
