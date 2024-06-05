using System;
using System.Collections.Generic;
using System.Data;

namespace Model
{
    /// <summary>
    /// Singleton class responsible for managing Peripheral Variables.
    /// </summary>
    [Serializable]
    public class PeripheralData
    {
        // PRIVATE CONSTRUCTOR:
        private PeripheralData()
        {
        }
        
        // TABLE:
        private DataTable _peripheralDataTable = new DataTable();

        public DataTable PeripheralDataTable
        {
            get => _peripheralDataTable;
        }
        
        // METHODS:
        public void InitializePeripheralData(string[] variableNames)
        {
            foreach (var name in variableNames)
            {
                _peripheralDataTable.Columns.Add(name, typeof(float));
            }
        }

        public void AddPeripheralData(float[] variables)
        {
            var i = 1;
            foreach (var variable in variables)
            {
                _peripheralDataTable.Rows.Add(i, variable);
                i++;
            }
        }
    }
}
    