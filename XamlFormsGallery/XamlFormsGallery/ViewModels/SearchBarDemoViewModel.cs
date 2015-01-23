using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;
using XamlFormsGallery.Mvvm;

namespace XamlFormsGallery.ViewModels
{
    public class SearchBarDemoViewModel : ViewModelBase
    {
        private ICommand _searchButtonPressedCommand;
        private string _resultsText;

        public string SearchText { private get; set; }

        public string ResultsText
        {
            get { return _resultsText; }
            private set { SetProperty(ref _resultsText, value); }
        }

        public ICommand SearchButtonPressedCommand
        {
            get { return _searchButtonPressedCommand ?? (_searchButtonPressedCommand = new Command(ExecuteSearchButtonPressedCommand)); }
        }

        private void ExecuteSearchButtonPressedCommand()
        {
            // Create a List and initialize the results Label.
            var list = new List<Tuple<Type, Type>>(); 
            ResultsText = "";

            // Get Xamarin.Forms assembly.
            Assembly xamarinFormsAssembly = typeof(View).GetTypeInfo().Assembly;

            // Loop through all the types.
            foreach (Type type in xamarinFormsAssembly.ExportedTypes)
            {
                TypeInfo typeInfo = type.GetTypeInfo();

                // Public types only.
                if (typeInfo.IsPublic)
                {
                    // Loop through the properties.
                    foreach (PropertyInfo property in typeInfo.DeclaredProperties)
                    {
                        // Check for a match
                        if (property.Name.Equals(SearchText))
                        {
                            // Add it to the list.
                            list.Add(Tuple.Create(type, property.PropertyType));
                        }
                    }
                }
            }

            if (list.Count == 0)
            {
                ResultsText =
                    String.Format("No Xamarin.Forms properties with " +
                                  "the name of {0} were found",
                        SearchText);
            }
            else
            {
                ResultsText = "The ";

                foreach (Tuple<Type, Type> tuple in list)
                {
                    ResultsText +=
                        String.Format("{0} type defines a property named {1} of type {2}",
                            tuple.Item1.Name, SearchText, tuple.Item2.Name);

                    // ReSharper disable once PossibleUnintendedReferenceComparison
                    if (tuple != list.Last())
                    {
                        ResultsText += "; and the ";
                    }
                }

                ResultsText += ".";
            }
        }
    }
}