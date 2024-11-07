using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double gramValue, poundValue;

        // ボタンで呼ばれるコマンド
        public ICommand PoundUnitToMetric {
            get; private set;
        }
        public ICommand MetricToImperialUnit {
            get; private set;
        }

        // 上のComboBoxで選択されている値
        public GramUnit CurrentMetricUnit {
            get; set;
        }

        // 下のComboBoxで選択されている値
        public PoundUnit CurrentImperialUnit {
            get; set;
        }

        public double MetricValue {
            get {
                return gramValue;
            }
            set {
                gramValue = value;
                OnPropertyChanged();
            }
        }

        public double ImperialValue {
            get {
                return poundValue;
            }
            set {
                poundValue = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel() {
        //    CurrentMetricUnit = gramUnit.Units.First();
            CurrentImperialUnit = PoundUnit.Units.First();

            MetricToImperialUnit = new DelegateCommand(
                () => ImperialValue = CurrentImperialUnit.FromMetricUnit(
                    CurrentMetricUnit, MetricValue));

        //    ImperialUnitToMetric = new DelegateCommand(
        //        () => MetricValue = CurrentMetricUnit.FromImperialUnit(
        //            CurrentImperialUnit, ImperialValue));
        }
    }

}


/*
< !--Window.DataContext >
        < !--SampleWeightUnitConverter.MainWindowViewNodel />
    < !--/ Window.DataContext >

            !< StackPanel Margin = "4" >
                < StackPanel Orientation = "Horizontal" >
                    < TextBox Width = "100" Margin = "4"
                 Text = "{Binding MetricValue, StringFormat={}{0:N3}}" />
            !        < ComboBox Width = "80" Margin = "4"
            !      ItemsSource = "{Binding Source={x:Static SampleUnitConverter:MetricUnit.Units}}"
            !!! < StackPanel Orientation = "Horizontal" HorizontalAlignment = "Center" >
             !       < Button Width = "40" Margin = "4" Content = "▲"
             !   Command = "{Binding ImperialUnitToMetric}" />
             !       < Button Width = "40" Margin = "4" Content = "▼"
             !   Command = "{Binding MetricToImperialUnit}" />
             !   </ StackPanel >
             !   < StackPanel Orientation = "Horizontal" >
             !       < TextBox Width = "100" Margin = "4"
             !    Text = "{Binding ImperialValue, StringFormat={}{0:N3}}" />
             !       < ComboBox Width = "80" Margin = "4"
             !     ItemsSource = "{Binding Source={x:Static SampleUnitConverter:ImperialUnit.Units}}"
             !     SelectedItem = "{Binding CurrentImperialUnit}" />
             !   </ StackPanel >
             !   </ StackPanel >

*/