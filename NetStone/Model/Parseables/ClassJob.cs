﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using HtmlAgilityPack;
using JetBrains.Annotations;
using NetStone.Definitions.Model;

namespace NetStone.Model.Parseables
{
    public class ClassJob : LodestoneParseable
    {
        private readonly ClassJobDefinition definition;

        public ClassJob(HtmlNode rootNode, ClassJobDefinition definition) : base(rootNode)
        {
            this.definition = definition;
        }

        /// <summary>
        /// Information about the Paladin class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Paladin => new ClassJobEntry(this.RootNode, this.definition.Paladin).GetOptional();
        
        /// <summary>
        /// Information about the Warrior class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Warrior => new ClassJobEntry(this.RootNode, this.definition.Warrior).GetOptional();
        
        /// <summary>
        /// Information about the Dark Knight class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry DarkKnight => new ClassJobEntry(this.RootNode, this.definition.DarkKnight).GetOptional();
        
        /// <summary>
        /// Information about the Gunbreaker class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Gunbreaker => new ClassJobEntry(this.RootNode, this.definition.Gunbreaker).GetOptional();
        
        /// <summary>
        /// Information about the Monk class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Monk => new ClassJobEntry(this.RootNode, this.definition.Monk).GetOptional();
        
        /// <summary>
        /// Information about the Dragoon class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Dragoon => new ClassJobEntry(this.RootNode, this.definition.Dragoon).GetOptional();
        
        /// <summary>
        /// Information about the Ninja class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Ninja => new ClassJobEntry(this.RootNode, this.definition.Ninja).GetOptional();
        
        /// <summary>
        /// Information about the Samurai class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Samurai => new ClassJobEntry(this.RootNode, this.definition.Samurai).GetOptional();
        
        /// <summary>
        /// Information about the Whitemage class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Whitemage => new ClassJobEntry(this.RootNode, this.definition.Whitemage).GetOptional();
        
        /// <summary>
        /// Information about the Scholar class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Scholar => new ClassJobEntry(this.RootNode, this.definition.Scholar).GetOptional();
        
        /// <summary>
        /// Information about the Astrologian class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Astrologian => new ClassJobEntry(this.RootNode, this.definition.Astrologian).GetOptional();
        
        /// <summary>
        /// Information about the Bard class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Bard => new ClassJobEntry(this.RootNode, this.definition.Bard).GetOptional();
        
        /// <summary>
        /// Information about the Machinist class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Machinist => new ClassJobEntry(this.RootNode, this.definition.Machinist).GetOptional();
        
        /// <summary>
        /// Information about the Dancer class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Dancer => new ClassJobEntry(this.RootNode, this.definition.Dancer).GetOptional();
        
        /// <summary>
        /// Information about the Blackmage class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Blackmage => new ClassJobEntry(this.RootNode, this.definition.Blackmage).GetOptional();
        
        /// <summary>
        /// Information about the Summoner class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Summoner => new ClassJobEntry(this.RootNode, this.definition.Summoner).GetOptional();
        
        /// <summary>
        /// Information about the Redmage class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Redmage => new ClassJobEntry(this.RootNode, this.definition.Redmage).GetOptional();
        
        /// <summary>
        /// Information about the Bluemage class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Bluemage => new ClassJobEntry(this.RootNode, this.definition.Bluemage).GetOptional();
        
        /// <summary>
        /// Information about the Carpenter class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Carpenter => new ClassJobEntry(this.RootNode, this.definition.Carpenter).GetOptional();
        
        /// <summary>
        /// Information about the Blacksmith class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Blacksmith => new ClassJobEntry(this.RootNode, this.definition.Blacksmith).GetOptional();
        
        /// <summary>
        /// Information about the Armorer class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Armorer => new ClassJobEntry(this.RootNode, this.definition.Armorer).GetOptional();

        /// <summary>
        /// Information about the Goldsmith class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Goldsmith => new ClassJobEntry(this.RootNode, this.definition.Goldsmith).GetOptional();

        /// <summary>
        /// Information about the Leatherworker class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Leatherworker => new ClassJobEntry(this.RootNode, this.definition.Leatherworker).GetOptional();
        
        /// <summary>
        /// Information about the Weaver class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Weaver => new ClassJobEntry(this.RootNode, this.definition.Weaver).GetOptional();

        /// <summary>
        /// Information about the Alchemist class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Alchemist => new ClassJobEntry(this.RootNode, this.definition.Alchemist).GetOptional();

        /// <summary>
        /// Information about the Miner class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Miner => new ClassJobEntry(this.RootNode, this.definition.Miner).GetOptional();

        /// <summary>
        /// Information about the Botanist class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Botanist => new ClassJobEntry(this.RootNode, this.definition.Botanist).GetOptional();
        
        /// <summary>
        /// Information about the Fisher class.
        /// </summary>
        [CanBeNull]
        public ClassJobEntry Fisher => new ClassJobEntry(this.RootNode, this.definition.Fisher).GetOptional();
    }
}
