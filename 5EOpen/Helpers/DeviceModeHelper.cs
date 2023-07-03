using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5EOpen.Helpers
{
    public static class DeviceModeHelper
    {

        public static bool UsesSafeArea()
        {
            bool usesSafeArea = false; 
            if (DeviceInfo.Platform == DevicePlatform.iOS)
            {
                var model = DeviceInfo.Model;
                var modelSplit = model.Split(',');

                if (modelSplit[0].Substring(0,4).ToLower() != "ipad" && modelSplit[0].ToLower() != "x86_64")
                {
                    var iphoneDescriptor = 0;
                    var iphone = 0;
                    try
                    {
                        iphoneDescriptor = Convert.ToInt32(modelSplit[0].ToLower().Replace("iphone", "").Replace("ipad", ""));
                        iphone = Convert.ToInt32(modelSplit[1]);
                    }
                    catch (Exception ex) 
                    {
                        return usesSafeArea = false; 
                    }

                    if (iphoneDescriptor >= 10)
                    {
                        switch (iphoneDescriptor)
                        {
                            case 10:
                                if (iphone == 3 || iphone == 6)
                                {
                                    usesSafeArea = true;
                                }
                                else
                                {
                                    usesSafeArea = false;
                                };
                                break;
                            case 12:
                                if (iphone == 8)
                                {
                                    usesSafeArea = false;
                                }
                                else
                                {
                                    usesSafeArea = true;
                                }
                                break;
                            default:
                                usesSafeArea = true; break;
                        }
                    }
                }

                if (DeviceInfo.DeviceType == DeviceType.Virtual)
                {
                    if (DeviceInfo.Name == "iPhone 12 mini" ||
                        DeviceInfo.Name == "iPhone 12" ||
                        DeviceInfo.Name == "iPhone 12 Pro" ||
                        DeviceInfo.Name == "iPhone 12 Pro Max" ||
                        DeviceInfo.Name == "iPhone 11 mini" ||
                        DeviceInfo.Name == "iPhone 11" ||
                        DeviceInfo.Name == "iPhone 11 Pro" ||
                        DeviceInfo.Name == "iPhone 11 Pro Max" ||
                        DeviceInfo.Name == "iPhone XR" ||
                        DeviceInfo.Name == "iPhone Xs" ||
                        DeviceInfo.Name == "iPhone Xs Max" ||
                        DeviceInfo.Name == "iPhone X")
                    {
                        usesSafeArea = true;
                    }
                }
                
            }
            return usesSafeArea;
        }
    }
}
