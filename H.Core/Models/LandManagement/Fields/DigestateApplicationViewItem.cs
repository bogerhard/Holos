﻿using System;
using H.Core.CustomAttributes;
using H.Core.Enumerations;
using H.Infrastructure;

namespace H.Core.Models.LandManagement.Fields
{
    public class DigestateApplicationViewItem : ModelBase
    {
        #region Fields

        private DigestateState _digestateState;

        private double _amountAppliedPerHectare;
        private double _amountOfNitrogenAppliedPerHectare;
        private double _amountOfCarbonAppliedPerHectare;

        private bool _attempToGoOverMaximum;

        #endregion

        #region Constructors

        public DigestateApplicationViewItem()
        {
            base.DateCreated = DateTime.Now;
            this.DigestateState = DigestateState.Raw;
        }

        #endregion

        #region Properties

        public DigestateState DigestateState
        {
            get => _digestateState;
            set => SetProperty(ref _digestateState, value);
        }

        public double MaximumAmountOfDigestateAvailablePerHectare { get; set; }

        /// <summary>
        /// Amount of digestate applied
        ///
        /// (kg ha^-1)
        /// </summary>
        [Units(MetricUnitsOfMeasurement.KilogramsPerHectare)]
        public double AmountAppliedPerHectare
        {
            get => _amountAppliedPerHectare;
            set
            {
                this.AttemptedToGoOverMaximum = false;

                if (value > this.MaximumAmountOfDigestateAvailablePerHectare)
                {
                    this.AttemptedToGoOverMaximum = true;
                    SetProperty(ref _amountAppliedPerHectare, this.MaximumAmountOfDigestateAvailablePerHectare);

                    return;
                }

                SetProperty(ref _amountAppliedPerHectare, value);
            } 
        }

        /// <summary>
        /// Amount of N applied
        ///
        /// (kg N ha^-1)
        /// </summary>
        public double AmountOfNitrogenAppliedPerHectare
        {
            get => _amountOfNitrogenAppliedPerHectare;
            set
            {
                SetProperty(ref _amountOfNitrogenAppliedPerHectare, value);
            }
        }

        /// <summary>
        /// Amount of C applied
        ///
        /// (kg C ha^-1)
        /// </summary>
        public double AmountOfCarbonAppliedPerHectare
        {
            get => _amountOfCarbonAppliedPerHectare;
            set
            {
                SetProperty(ref _amountOfCarbonAppliedPerHectare, value);
            } 
        }

        public bool AttemptedToGoOverMaximum
        {
            get => _attempToGoOverMaximum;
            set => SetProperty(ref _attempToGoOverMaximum, value);
        }

        #endregion

        #region Public Method

        

        #endregion
    }
}