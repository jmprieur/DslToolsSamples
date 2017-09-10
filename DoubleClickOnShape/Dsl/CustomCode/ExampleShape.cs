using Microsoft.VisualStudio.Modeling.Diagrams;
using System.Windows.Forms;
using System.Linq;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Company.DoubleClickOnShape
{
    /// <summary>
    /// Class derived from TextField, in order to override the default behavior of the Text decorator
    /// to provide a way to trigger a custom editor on double click
    /// </summary>
    public class CustomTextFieldWithEditorOnDoubleClick : TextField
    {
        /// <summary>
        /// Constructor of our Custom text field
        /// </summary>
        /// <param name="fieldName"></param>
        public CustomTextFieldWithEditorOnDoubleClick(string fieldName) : base(fieldName)
        {
        }

        /// <summary>
        /// When the user will double-click on the text field, this will show a message box
        /// and then will set the value of the field to something (here "Changed!")
        /// Instead of the Message Box the customer will need to provide his own dialogbox
        /// </summary>
        /// <param name="e"></param>
        public override void OnDoubleClick(DiagramPointEventArgs e)
        {
            base.OnDoubleClick(e);
            MessageBox.Show("Double click in the texual decorator");
            this.SetValue(e.HitDiagramItem.Shape, "Changed!");
        }

        /// <summary>
        /// In order to be able to double-click on the textfield, we need to prevent the text from
        /// being editable. this is what this override does
        /// </summary>
        /// <param name="parentShape"></param>
        /// <param name="view"></param>
        /// <returns></returns>
        public override bool CanEditValue(ShapeElement parentShape, DiagramClientView view)
        {
            return false;
        }
    }

    partial class ExampleShape
    {
        /// <summary>
        /// Initialization of the decorators.
        /// </summary>
        /// <param name="shapeFields"></param>
        protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
        {
            // We let the generated method do all its work
            base.InitializeShapeFields(shapeFields);

            // Then we remove the "NameDecorator"
            TextField previous = shapeFields.OfType<TextField>().FirstOrDefault(f => f.Name == "NameDecorator");
            shapeFields.Remove(previous);

            // And we re-create it so that it's really a customer text field with an editor on double click
            DslDiagrams::TextField field1 = new CustomTextFieldWithEditorOnDoubleClick("NameDecorator");
            field1.DefaultText = global::Company.DoubleClickOnShape.DoubleClickOnShapeDomainModel.SingletonResourceManager.GetString("ExampleShapeNameDecoratorDefaultText");
            field1.DefaultFocusable = true;
            field1.DefaultAutoSize = true;
            field1.AnchoringBehavior.MinimumHeightInLines = 1;
            field1.AnchoringBehavior.MinimumWidthInCharacters = 1;
            field1.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
            shapeFields.Add(field1);

        }
    }
}
