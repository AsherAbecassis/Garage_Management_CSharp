﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Fuel : Engine
    {
        private float m_CurrentFuel;
        private float m_MaxFuel;
        private eFuelType m_FuelType;

        public enum eFuelType
        {
            Octan95,
            Octan96,
            Octan98,
            Soler
        }

        public Fuel(float i_MaxFuel, float i_CurrentFuel, eFuelType i_FuelType)
        {
            this.m_MaxFuel = i_MaxFuel;
            this.m_CurrentFuel = i_CurrentFuel;
            this.m_FuelType = i_FuelType;
        }

        public float CurrentFuel
        {
            get
            {
                return this.m_CurrentFuel;
            }
            set
            {
                this.m_CurrentFuel = value;
            }
        }
        public float MaxFuel
        {
            get
            {
                return this.m_MaxFuel;
            }
            set
            {
                this.m_MaxFuel = value;
            }
        }

        public eFuelType FuelType
        {
            get
            {
                return this.m_FuelType;
            }
            set
            {
                this.m_FuelType = value;
            }
        }


        public override void AddEnergy(float i_FuelToAdd)
        {
            
            if(this.m_CurrentFuel + i_FuelToAdd <= this.m_MaxFuel)
            {
                this.m_CurrentFuel += i_FuelToAdd;
            }
            else
            {
                throw new ValueOutOfRangeException(new Exception(), 0, MaxFuel - CurrentFuel);
            }
        }
    }
}
