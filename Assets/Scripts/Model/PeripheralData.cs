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
        private DataTable _peripheralDataTable;
        private bool _isInitialized = false;

        public DataTable PeripheralDataTable
        {
            get => _peripheralDataTable;
        }
        
        // METHODS:
        public void InitializePeripheralData(string[] variableNames)
        {
            _peripheralDataTable = new DataTable();
            _isInitialized = true;
            foreach (var name in variableNames)
            {
                _peripheralDataTable.Columns.Add(name, typeof(float));
            }
        }

        public void AddPeripheralData(float[] variables)
        {
            if (_isInitialized)
            {
                if (_peripheralDataTable.Columns.Count == variables.Length)
                {
                    var i = 1;
                    foreach (var variable in variables)
                    {
                        _peripheralDataTable.Rows.Add(i, variable);
                        i++;
                    }
                }
                else
                {
                    throw new ArgumentException("Input Array Length is incompatible with the instantiated Peripheral Data Table.");
                }
            }
            else
            {
                throw new InvalidOperationException("Peripheral Data Table is not instantiated.");
            }
            
        }
    }
}
    