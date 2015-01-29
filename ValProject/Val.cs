using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;

namespace ValProject
{
    /// <summary>
    /// Деталь вала.
    /// </summary>
    public class Val
    {
        /// <summary>
        /// Апи инвентора.
        /// </summary>
        private InventorApi _inventorApi;

        /// <summary>
        /// Текущая точка.
        /// </summary>
        private Point2d _curPoint;

        /// <summary>
        /// Параметры вала.
        /// </summary>
        public ValParameters ValParameters { get; private set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="valParameters">Параметры вала.</param>
        /// <param name="inventorApi">Апишка инвентора.</param>
        public Val(ValParameters valParameters, InventorApi inventorApi)
        {
            _inventorApi = inventorApi;
            ValParameters = valParameters;
        }

        /// <summary>
        /// Метод создания модели.
        /// </summary>
        public void Build()
        {
            //Текущая точка по центру.
            _curPoint = _inventorApi.TransientGeometry.CreatePoint2d(0, 0);

            BuildStem1();
            BuildStem2();
            BuildStem3();
            BuildStem4();
            BuildStem5();
            BuildTeeth();
            
        }
        /// <summary>
        /// Зубья вала.
        /// </summary>
        private void BuildTeeth()
        {
            //Многоугольник для выдавливания
            PlanarSketch StemSketchQ = MakeNewSketch(3,
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.
            Point2d pointQ = _inventorApi.TransientGeometry.CreatePoint2d(ValParameters.GetParameter(ParameterType.RadiusThirdLevel).Value + 3, 0);
            Point2d CenterPointQ = _inventorApi.TransientGeometry.CreatePoint2d(ValParameters.GetParameter(ParameterType.RadiusThirdLevel).Value, 0);
            DrawPolygon(pointQ, StemSketchQ, CenterPointQ);
            

            ExtrudeDefinition extrudeDefQ =
               _inventorApi.PartDefinition.
               Features.
               ExtrudeFeatures.
               CreateExtrudeDefinition(StemSketchQ.Profiles.AddForSolid(), PartFeatureOperationEnum.kCutOperation);
               extrudeDefQ.SetDistanceExtent(
                ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value,
                PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
               ExtrudeFeature extrudeQ = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDefQ);



            //Базовые оси
            //для создания массива.
            WorkAxis XAxis = _inventorApi.PartDefinition.WorkAxes[1];
            WorkAxis YAxis = _inventorApi.PartDefinition.WorkAxes[2];
            WorkAxis ZAxis = _inventorApi.PartDefinition.WorkAxes[3];

            //Create an object collection
            ObjectCollection objectCollection = _inventorApi.CreateObjectCollection();
            objectCollection.Add(extrudeQ);
                _inventorApi.PartDefinition.Features.CircularPatternFeatures.Add(
                    objectCollection,
                    ZAxis,
                    true,
                    (int)(ValParameters.GetParameter(ParameterType.RadiusThirdLevel).Value/1.5),
                    "360 deg",
                    true,
                    PatternComputeTypeEnum.kAdjustToModelCompute);
        }

        private void BuildStem5()
        {
            PlanarSketch StemSketch5 = MakeNewSketch(3, 
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.
            // transientGeometry = invApp.TransientGeometry;
            // Point2d point2 = transientGeometry.CreatePoint2d(0, 0);   //построен эскиз 
            DrawCircle(ValParameters.GetParameter(ParameterType.RadiusFifthLevel).Value, StemSketch5, _curPoint);

            ExtrudeDefinition extrudeDef5 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch5.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef5.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthFifthLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude5 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef5);
        }

        private void BuildStem4()
        {
            PlanarSketch StemSketch4 = MakeNewSketch(3,
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.
            // transientGeometry = invApp.TransientGeometry;
            // Point2d point2 = transientGeometry.CreatePoint2d(0, 0);   //построен эскиз 
            DrawCircle(ValParameters.GetParameter(ParameterType.RadiusFourthLevel).Value, StemSketch4, _curPoint);

            ExtrudeDefinition extrudeDef4 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch4.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef4.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthFourthLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude4 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef4);
        }

        private void BuildStem3()
        {
            PlanarSketch StemSketch3 = MakeNewSketch(3,
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value +
                ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.

            DrawCircle(ValParameters.GetParameter(ParameterType.RadiusThirdLevel).Value, StemSketch3, _curPoint);
           // StemSketch3.Profiles.AddForSolid();

            ExtrudeDefinition extrudeDef3 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch3.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef3.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthThirdLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude3 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef3);
        }

        private void BuildStem2()
        {
            PlanarSketch StemSketch2 = MakeNewSketch(3, 
                ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value);// второй параметр отодвигает по Z координате на заданную длину.
            DrawCircle(ValParameters.GetParameter(ParameterType.RadiusSecondLevel).Value, StemSketch2, _curPoint);

            ExtrudeDefinition extrudeDef2 =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch2.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef2.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthSecondLevel).Value, PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude2 = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef2);
        }

        private void BuildStem1()
        {
            PlanarSketch StemSketch = MakeNewSketch(3, 0); //[1 - ZY; 2 - ZX; 3 - XY]

            Point2d point = _inventorApi.TransientGeometry.CreatePoint2d(0, 0);   //построен эскиз 
            DrawCircle(ValParameters.GetParameter(ParameterType.RadiusFirstLevel).Value, StemSketch, point);

            ExtrudeDefinition extrudeDef =
                _inventorApi.PartDefinition.
                Features.
                ExtrudeFeatures.
                CreateExtrudeDefinition(StemSketch.Profiles.AddForSolid(), PartFeatureOperationEnum.kJoinOperation);
            extrudeDef.SetDistanceExtent(ValParameters.GetParameter(ParameterType.LengthFirstLevel).Value,
                PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
            ExtrudeFeature extrude = _inventorApi.PartDefinition.Features.ExtrudeFeatures.Add(extrudeDef);

        }

        //Для построения от рабочих плоскостей.
        private PlanarSketch MakeNewSketch(int n, double Offset)  
        {
            Inventor.WorkPlane MainPlane = _inventorApi.PartDefinition.WorkPlanes[n];       //[1 - ZY; 2 - ZX; 3 - XY]
            Inventor.WorkPlane OffsetPlane = _inventorApi.PartDefinition.WorkPlanes.AddByPlaneAndOffset(MainPlane, Offset, false);
            Inventor.PlanarSketch sketch = _inventorApi.PartDefinition.Sketches.Add(OffsetPlane, false);
            return sketch;
        }

        //Для построения на поверхности детали.
        private PlanarSketch MakeNewSketch(Object Face, double Offset) 
        {
            Inventor.WorkPlane OffsetPlane = _inventorApi.PartDefinition.WorkPlanes.AddByPlaneAndOffset(Face, Offset, false);
            Inventor.PlanarSketch sketch = _inventorApi.PartDefinition.Sketches.Add(OffsetPlane, false);
            //Face Face1 = partDef.SurfaceBodies[1].Faces[3];
            return sketch;
        }

        //Отрисовка многоугольника для зубьев.
        private void DrawPolygon(Point2d CircumferencePoint, PlanarSketch sketch, Point2d CenterPoint)
        {
            sketch.SketchLines.AddAsPolygon(6, CenterPoint, CircumferencePoint, false);
            //SketchCircle Circle = sketch.SketchCircles.AddByCenterRadius(CenterPoint, Diameter / 20);
        }

        //Отрисовка круга для звеньев.
        private void DrawCircle(double Diameter, PlanarSketch sketch, Point2d CenterPoint)
        {
            sketch.SketchCircles.AddByCenterRadius(CenterPoint, Diameter);
            //SketchCircle Circle = sketch.SketchCircles.AddByCenterRadius(CenterPoint, Diameter / 20);
        }
    }
}
