using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Hardware.Behaviors
{
    internal class EmailValidationBehavior : Behavior<Editor>
    {
        private readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        protected override void OnAttachedTo(Editor bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!(sender is Editor editor))
                return;

            editor.TextColor = EmailRegex.IsMatch(editor.Text) ? Color.Default : Color.IndianRed;
        }

        protected override void OnDetachingFrom(Editor bindable)
        {
            bindable.TextChanged -= Bindable_TextChanged;
            base.OnDetachingFrom(bindable);
        }
    }
}
