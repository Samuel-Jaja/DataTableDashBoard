using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFConverters_MVVM
{
    public class MainViewModel : INotifyPropertyChanged
    {
            #region Constructor
            public MainViewModel()
            {
            SelectedSize = TextSize.Big;
            SelectedSafety = Safety.Dangerous;
            }
            #endregion

            #region Safety Rules
            public List<Safety> SafetyList
            {
                get
                {
                    return Enum.GetValues(typeof(Safety)).Cast<Safety>().ToList();
                }
            }
            private Safety _selectedSafety;
            public Safety SelectedSafety
            {
                get
                {
                    return _selectedSafety;
                }
                set
                {
                    _selectedSafety = value;
                    OnPropertyChanged("SelectedSafety");
                }
            }
            #endregion

            #region Text Content
            private string _textContent;
            public string TextContent
            {
                get
                {
                    return _textContent;
                }
                set
                {
                    _textContent = value;
                    OnPropertyChanged("TextContent");
                }
            }
            private void UpdateText()
            {
                switch (SelectedSize)
                {
                    case TextSize.Small:
                        TextContent = "CypherCrescent Group";
                        break;
                    case TextSize.Medium:
                        TextContent = "CypherCrescent Group";
                        break;
                    case TextSize.Big:
                        TextContent = "CypherCrescent Group";
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region For Text Size
            public List<TextSize> TextSizeList
            {
                get
                {
                    return Enum.GetValues(typeof(TextSize)).Cast<TextSize>().ToList();
                }
            }
            private TextSize _selectedTextSize;
            public TextSize SelectedSize
            {
                get
                {
                    return _selectedTextSize;
                }
                set
                {
                    _selectedTextSize = value;
                    OnPropertyChanged("SelectedSize");
                    UpdateText();
                }
            }
            #endregion

            #region For Visibility
            private bool _isVisibleChecked;
            public bool IsVisibleChecked
            {
                get
                {
                    return _isVisibleChecked;
                }
                set
                {
                    _isVisibleChecked = value;
                    OnPropertyChanged("IsVisibleChecked");
                }
            }
            #endregion

            #region For Property Changed
            public event PropertyChangedEventHandler? PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
            #endregion
    }

}

