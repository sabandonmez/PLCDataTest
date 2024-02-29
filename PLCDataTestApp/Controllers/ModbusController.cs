using EasyModbus;
using Entities.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace PLCDataTestApp.Controllers
{
    public class ModbusController:Controller
    {

    public IActionResult Index()
    {
       var model = new ModbusOperationModel
            {
                Connection = true 
            };
            return View(model);
    }

        [HttpPost]
        public IActionResult Index(string ipAddress, int port, int slaveId)
        {
            try
            {
                ModbusClient modbusClient = new ModbusClient(ipAddress, port)
                {
                    UnitIdentifier = (byte)slaveId
                };

                modbusClient.Connect();
                modbusClient.Disconnect(); 

                return Json(true); 
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }


        [HttpPost]
        public IActionResult ReadData(ModbusConnectDto model)
        {
            try
            {
                    var modbusClient = new ModbusClient(model.IpAddress, model.Port);
                    modbusClient.UnitIdentifier = model.SlaveId;
                    modbusClient.Connect();
                    int[] readData = modbusClient.ReadHoldingRegisters(model.DataAddress, model.DataSize);
                    modbusClient.Disconnect();
                    return Json(new { success = true, data = readData }); 

            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult WriteData(ModbusConnectDto model)
        {
            try
            {
                    var modbusClient = new ModbusClient(model.IpAddress, model.Port);
                    modbusClient.UnitIdentifier = model.SlaveId; 
                    modbusClient.Connect();
                    int writeValue = int.Parse(model.WriteValue);
                    modbusClient.WriteMultipleRegisters(model.DataAddress, new int[] { writeValue });
                    modbusClient.Disconnect();
                    return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }



    }
}

