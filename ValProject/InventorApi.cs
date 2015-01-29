using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Runtime.InteropServices;

namespace ValProject
{
    /// <summary>
    /// Иницилиазириует Инвентор.
    /// </summary>
    public class InventorApi
    {
        /// <summary>
        /// Ссылка на приложение Инвентора.
        /// </summary>
        private Application _invApp;

        /// <summary>
        /// Документ в приложении.
        /// </summary>
        private PartDocument _partDoc;

        /// <summary>
        /// Описание документа.
        /// </summary>
        private PartComponentDefinition _partDef;

        /// <summary>
        /// Геометрия приложения.
        /// </summary>
        private TransientGeometry _transGeometry;

        /// <summary>
        /// Иницилиазирован ли Инвентор.
        /// </summary>
        private bool _inited;

        /// <summary>
        /// Описание документа.
        /// </summary>
        public PartComponentDefinition PartDefinition
        {
            get
            {
                if (!_inited)
                    Init();
                return _partDef;
            }
        }

        /// <summary>
        /// Геометрия приложения.
        /// </summary>
        public TransientGeometry TransientGeometry
        {
            get
            {
                if (!_inited)
                    Init();
                return _transGeometry;
            }
        }

        /// <summary>
        /// Создание объекта коллекции
        /// </summary>
        /// <returns></returns>
        public ObjectCollection CreateObjectCollection()
        {
            if (!_inited)
                Init();
            return _invApp.TransientObjects.CreateObjectCollection();
        }

        /// <summary>
        /// Инилизировать Инвентор и подготовить переменные.
        /// </summary>
        private void Init()
        {
            _invApp = null;
            try
            {
                _invApp = (Application)Marshal.GetActiveObject("Inventor.Application");
            }
            catch (Exception)
            {
                try
                {
                    Type invAppType = Type.GetTypeFromProgID("Inventor.Application");

                    _invApp = (Application)Activator.CreateInstance(invAppType);
                    _invApp.Visible = true;

                    //Note: if the Inventor session is left running after this
                    //form is closed, there will still an be and Inventor.exe 
                    //running. We will use this Boolean to test in Form1.Designer.cs 
                    //in the dispose method whether or not the Inventor App should
                    //be shut down when the form is closed.

                }
                catch (Exception)
                {
                    //MessageBox.Show(ex2.ToString());
                    System.Windows.Forms.MessageBox.Show(@"Не получилось запустить инвентор.");
                }
            }

            _partDoc = (PartDocument)_invApp.Documents.Add //В открытом приложении создаем документ
                (DocumentTypeEnum.kPartDocumentObject,
                    _invApp.FileManager.GetTemplateFile
                        (DocumentTypeEnum.kPartDocumentObject,
                            SystemOfMeasureEnum.kMetricSystemOfMeasure));

            _partDef = _partDoc.ComponentDefinition; //Описание документа
            //AssemblyDocument assDoc = (AssemblyDocument)_invApp.ActiveDocument;
            //_assemblyDef = assDoc.ComponentDefinition;
            _transGeometry = _invApp.TransientGeometry; //инициализация метода геометрии

            _inited = true;
        }
    }
}
