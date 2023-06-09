﻿using MauiReactor;
using MauiReactor.Shapes;
using System;

namespace TestMauiReactor.Pages
{
    internal class HomePage : Component
    {
        public override VisualNode Render()
        {
            return new ContentPage()
            {
                new Grid("auto, auto, auto, auto, auto","*")
                {
                    new VStack()
                    {
                        new Label()
                        .FontFamily("BarlowSemiBold")
                        .TextColor(Colors.Black)
                        .Text("Hello")
                        .FontSize(24),

                        new Label()
                        .FontFamily("BarlowSemiBold")
                        .TextColor(Color.FromArgb("535cdd"))
                        .Text("LukeWire")
                        .FontSize(24)
                    }
                    .GridRow(0)
                    .GridColumn(0),

                    new FlexLayout()
                    {
                        DayText("Mon", "8"),
                        DayText("Tue", "9"),
                        DayText("Wed", "10"),
                        DayText("Thu", "11"),
                        DayText("Fri", "12"),
                        DayText("Sat", "13"),
                        DayText("Sun", "14"),
                    }
                    .Direction(Microsoft.Maui.Layouts.FlexDirection.Row)
                    .JustifyContent(Microsoft.Maui.Layouts.FlexJustify.SpaceBetween)
                    .GridRow(1)
                    .Margin(0, 50,0,0)
                    .HFill(),

                    new Grid("*", "*,*")
                    {
                        new Image()
                        .Source("running")
                        .GridColumn(0)
                        .WidthRequest(200),

                        new VStack()
                        {
                            new Label()
                            .Text("Today you run for")
                            .TextColor(Colors.Black)
                            .HorizontalTextAlignment(TextAlignment.Center)
                            .FontSize(32)
                            .FontFamily("BarlowSemiBold"),

                            new Label()
                            .Text("5.31 km")
                             .TextColor(Color.FromArgb("535cdd"))
                            .HorizontalTextAlignment(TextAlignment.Center)
                            .FontSize(50)
                            .FontFamily("BarlowSemiBold")
                            .Margin(0,20,0,0),

                            new Button()
                            .WidthRequest(170)
                            .CornerRadius(40)
                            .FontSize(22)
                            .Text("Details")
                            .TextColor(Colors.White)
                            .Background(new Microsoft.Maui.Controls.LinearGradientBrush()
                            {
                                StartPoint = new Point(0, 1),
                                EndPoint = new Point(1, 0),
                                GradientStops = new Microsoft.Maui.Controls.GradientStopCollection()
                                            {
                                                new Microsoft.Maui.Controls.GradientStop(Color.FromArgb("fe5b53"), Convert.ToSingle(0.0)),
                                                new Microsoft.Maui.Controls.GradientStop(Color.FromArgb("ff826c"), Convert.ToSingle(1.1))
                                            }
                            })
                            .Margin(0,20,0,0)
                        }
                        .GridColumn(1)
                    }
                    .GridRow(2)
                    .Margin(0, 100, 0 ,0),

                    new Border()
                    {
                        new Grid("*","*,*")
                        {
                            new VStack(10)
                            {
                                HealthText("3680", "steps"),

                                new Line()
                                .HeightRequest(0.5)
                                .BackgroundColor(Colors.White)
                                .Opacity(0.1),

                                HealthText("98", "bpm"),

                                 new Line()
                                .HeightRequest(0.5)
                                .BackgroundColor(Colors.White)
                                .Opacity(0.1),

                                HealthText("460", "calories"),
                            }
                            .GridColumn(0)
                        }
                        .Padding(50,20)
                    }
                    .Margin(0,30)
                    .GridRow(3)
                    .HeightRequest(350)
                    .StrokeShape(new RoundRectangle()
                                    .CornerRadius(new CornerRadius(30)))
                    .Background(new Microsoft.Maui.Controls.LinearGradientBrush()
                    {
                        StartPoint = new Point(0, 1),
                        EndPoint = new Point(1, 0),
                        GradientStops = new Microsoft.Maui.Controls.GradientStopCollection()
                                    {
                                        new Microsoft.Maui.Controls.GradientStop(Color.FromArgb("535cdd"), Convert.ToSingle(0.0)),
                                        new Microsoft.Maui.Controls.GradientStop(Color.FromArgb("667fe6"), Convert.ToSingle(1.1))
                                    }
                    })
                }
            }
            .Background(Colors.White)
            .Padding(30, 50);
        }

        VStack DayText(string week, string day)
        {
            return new VStack()
            {
                new Label()
                .TextColor(Colors.LightSlateGray)
                .Text(week)
                .FontSize(24)
                .FontFamily("BarlowRegular")
                .HCenter()
                ,

                new Label()
                .TextColor(Colors.Black)
                .Text(day)
                .FontSize(30)
                .FontFamily("BarlowSemiBold")
                .HCenter()
            };
        }
        Grid HealthText(string count, string unit)
        {
            return new Grid()
            {
                new VStack()
                {
                    new Label()
                        .Text(count)
                        .TextColor(Colors.White)
                        .FontSize(50)
                        .FontFamily("BarlowSemiBold")
                        ,

                    new Label()
                        .Text(unit)
                        .TextColor(Colors.White)
                        .FontSize(20)
                        .Opacity(0.5)
                        .FontFamily("BarlowSemiRegular")
                        .HEnd(),
                }
                .HEnd()
            };
        }
    }
}
