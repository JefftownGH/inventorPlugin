using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValProject
{
    /// <summary>
    /// Параметры вала.
    /// </summary>
    public class ValParameters
    {
        /// <summary>
        /// Ассоциативный массив, отображающий тип параметра на значение параметра.
        /// </summary>
        private readonly Dictionary<ParameterType, Parameter> _parameters = new Dictionary<ParameterType,Parameter>();

        private bool _validationStarted;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ValParameters()
        { 
            _parameters[ParameterType.LengthFirstLevel] = new Parameter(5, 1, 100);
            _parameters[ParameterType.LengthSecondLevel] = new Parameter(5, 1, 100);
            _parameters[ParameterType.LengthThirdLevel] = new Parameter(5, 1, 100);
            _parameters[ParameterType.LengthFourthLevel] = new Parameter(5, 1, 100);
            _parameters[ParameterType.LengthFifthLevel] = new Parameter(5, 1, 100);

            _parameters[ParameterType.RadiusFirstLevel] = new Parameter(5, 4, 100);
            _parameters[ParameterType.RadiusSecondLevel] = new Parameter(10, 6, 100);
            _parameters[ParameterType.RadiusThirdLevel] = new Parameter(15, 11, 100);
            _parameters[ParameterType.RadiusFourthLevel] = new Parameter(20, 16, 100);
            _parameters[ParameterType.RadiusFifthLevel] = new Parameter(25, 21, 100);

            _parameters[ParameterType.NumTeeth] = new Parameter(5, 1, 10);

            foreach (Parameter p in _parameters.Values)
            {
                p.ParameterChanged += OnParameterChanged; //
            }

            Validate();
        }

        /// <summary>
        /// Получить значение параметра по типу параметра.
        /// </summary>
        /// <param name="type">Тип параметра.</param>
        /// <returns>Значение параметра.</returns>
        public Parameter GetParameter(ParameterType type)
        {
            return _parameters[type];
        }

        /// <summary>
        /// Валидация параметров. Привидение параметра к допустимому значению.
        /// </summary>
        private void Validate()
        {
            if (_validationStarted)
                return;
            _validationStarted = true;
            

           // if (_parameters[ParameterType.RadiusSecondLevel].MinValue <= _parameters[ParameterType.RadiusFirstLevel].Value)
                _parameters[ParameterType.RadiusSecondLevel].MinValue = _parameters[ParameterType.RadiusFirstLevel].Value + 1;

          //  if (_parameters[ParameterType.RadiusThirdLevel].MinValue <= _parameters[ParameterType.RadiusSecondLevel].Value)
                _parameters[ParameterType.RadiusThirdLevel].MinValue = _parameters[ParameterType.RadiusSecondLevel].Value + 1;

          //  if (_parameters[ParameterType.RadiusFourthLevel].MaxValue >= _parameters[ParameterType.RadiusThirdLevel].Value)
                _parameters[ParameterType.RadiusFourthLevel].MaxValue = _parameters[ParameterType.RadiusThirdLevel].Value - 1;

          //  if (_parameters[ParameterType.RadiusFifthLevel].MaxValue >= _parameters[ParameterType.RadiusFourthLevel].Value)
                _parameters[ParameterType.RadiusFifthLevel].MaxValue = _parameters[ParameterType.RadiusFourthLevel].Value - 1;

                _validationStarted = false;
        }

        /// <summary>
        /// Эвент срабатывает при изменении параметра в ParameterControl. Подписка 
        /// </summary>
        private void OnParameterChanged(object o, EventArgs e) 
        {
            Validate();
        }
    }
}
