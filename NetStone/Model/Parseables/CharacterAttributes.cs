﻿using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using NetStone.Definitions.Model;

namespace NetStone.Model.Parseables
{
    public class CharacterAttributes : LodestoneParseable
    {
        private readonly CharacterAttributesDefinition definition;

        public CharacterAttributes(HtmlNode rootNode, CharacterAttributesDefinition definition) : base(rootNode)
        {
            this.definition = definition;
        }

        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Strength => int.Parse(ParseInnerText(this.definition.Strength));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Dexterity => int.Parse(ParseInnerText(this.definition.Dexterity));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Vitality => int.Parse(ParseInnerText(this.definition.Vitality));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Intelligence => int.Parse(ParseInnerText(this.definition.Intelligence));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Mind => int.Parse(ParseInnerText(this.definition.Mind));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int CriticalHitRate => int.Parse(ParseInnerText(this.definition.CriticalHitRate));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Determination => int.Parse(ParseInnerText(this.definition.Determination));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int DirectHitRate => int.Parse(ParseInnerText(this.definition.DirectHitRate));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Defense => int.Parse(ParseInnerText(this.definition.Defense));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int MagicDefense => int.Parse(ParseInnerText(this.definition.MagicDefense));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int AttackPower => int.Parse(ParseInnerText(this.definition.AttackPower));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int SkillSpeed => int.Parse(ParseInnerText(this.definition.AttackPower));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int AttackMagicPotency => int.Parse(ParseInnerText(this.definition.AttackMagicPotency));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int HealingMagicPotency => int.Parse(ParseInnerText(this.definition.HealingMagicPotency));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int SpellSpeed => int.Parse(ParseInnerText(this.definition.SpellSpeed));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Tenacity => int.Parse(ParseInnerText(this.definition.Tenacity));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Piety => int.Parse(ParseInnerText(this.definition.Piety));
        
        /// <summary>
        /// This characters' strength value.
        /// </summary>
        public int Hp => int.Parse(ParseInnerText(this.definition.Hp));
        
        /// <summary>
        /// This characters' MP, GP or CP value. Check the <see cref="MpGpCpParameterName"/> Property to find out which.
        /// </summary>
        public int MpGpCp => int.Parse(ParseInnerText(this.definition.MpGpCp));
        
        /// <summary>
        /// Value indicating which of MP, GP, or CP is indicated by <see cref="MpGpCp"/>.
        /// </summary>
        public string MpGpCpParameterName => ParseInnerText(this.definition.MpGpCpParameterName);
    }
}