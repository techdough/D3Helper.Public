﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3Helper.A_Enums
{
    public enum Skills
    {
        barbarian_bash = 79242,
        barbarian_battlerage = 79076,
        barbarian_calloftheancients = 80049,
        barbarian_cleave = 80263,
        barbarian_earthquake = 98878,
        barbarian_frenzy = 78548,
        barbarian_furiouscharge = 97435,
        barbarian_groundstomp = 79446,
        barbarian_hammeroftheancients = 80028,
        barbarian_ignorepain = 79528,
        barbarian_leap = 93409,
        barbarian_overpower = 159169,
        barbarian_overpower_cowking = 368239,
        barbarian_rend = 70472,
        barbarian_revenge = 109342,
        barbarian_seismicslam = 86989,
        barbarian_sprint = 78551,
        barbarian_threateningshout = 79077,
        barbarian_whirlwind = 96296,
        barbarian_wrathoftheberserker = 79607,
        demonhunter_bolas = 77552,
        demonhunter_caltrops = 129216,
        demonhunter_chakram = 129213,
        demonhunter_clusterarrow = 129214,
        demonhunter_elementalarrow = 131325,
        demonhunter_fanofknives = 77546,
        demonhunter_grenades = 86610,
        demonhunter_hungeringarrow = 129215,
        demonhunter_impale = 131366,
        demonhunter_markedfordeath = 130738,
        demonhunter_multishot = 77649,
        demonhunter_preparation = 129212,
        demonhunter_preparation_passive = 324845,
        demonhunter_rainofvengeance = 130831,
        demonhunter_rapidfire = 131192,
        demonhunter_sentry = 129217,
        demonhunter_shadowpower = 130830,
        demonhunter_smokescreen = 130695,
        demonhunter_spiketrap = 75301,
        demonhunter_strafe = 134030,
        demonhunter_vault = 111215,
        lr_boss_sprint = 366527,
        monk_blindingflash = 136954,
        monk_breathofheaven = 69130,
        monk_cripplingwave = 96311,
        monk_cyclonestrike = 223473,
        monk_deadlyreach = 96019,
        monk_explodingpalm = 97328,
        monk_fistsofthunder = 95940,
        monk_lashingtailkick = 111676,
        monk_serenity = 96215,
        monk_sevensidedstrike = 96694,
        monk_sweepingwind = 96090,
        monk_tempestrush = 121442,
        monk_waveoflight = 96033,
        monk_wayofthehundredfists = 97110,
        p4_sasquatch_leap = 415053,
        unique_monster_tempestrush_prototype = 256060,
        witchdoctor_acidcloud = 70455,
        witchdoctor_bigbadvoodoo = 117402,
        witchdoctor_corpsespider = 69866,
        witchdoctor_fetisharmy = 72785,
        witchdoctor_firebats = 105963,
        witchdoctor_firebomb = 67567,
        witchdoctor_gargantuan = 30624,
        witchdoctor_graspofthedead = 69182,
        witchdoctor_haunt = 83602,
        witchdoctor_hex = 30631,
        witchdoctor_horrify = 67668,
        witchdoctor_locust_swarm = 69867,
        witchdoctor_massconfusion = 67600,
        witchdoctor_piranhas = 347265,
        witchdoctor_plagueoftoads = 106465,
        witchdoctor_poisondart = 103181,
        witchdoctor_sacrifice = 102572,
        witchdoctor_soulharvest = 67616,
        witchdoctor_spiritbarrage = 108506,
        witchdoctor_spiritwalk = 106237,
        witchdoctor_summonzombiedog = 102573,
        witchdoctor_wallofzombies = 134837,
        witchdoctor_zombiecharger = 74003,
        wizard_arcaneorb = 30668,
        wizard_arcanetorrent = 134456,
        wizard_archon = 134872,
        wizard_blizzard = 30680,
        wizard_diamondskin = 75599,
        wizard_disintegrate = 91549,
        wizard_electrocute = 1765,
        wizard_energyarmor = 86991,
        wizard_energytwister = 77113,
        wizard_explosiveblast = 87525,
        wizard_familiar = 99120,
        wizard_frostnova = 30718,
        wizard_hydra = 30725,
        wizard_icearmor = 73223,
        wizard_magicmissile = 30744,
        wizard_magicweapon = 76108,
        wizard_meteor = 69190,
        wizard_mirrorimage = 98027,
        wizard_rayoffrost = 93395,
        wizard_shockpulse = 30783,
        wizard_slowtime = 1769,
        wizard_spectralblade = 71548,
        wizard_stormarmor = 74499,
        wizard_teleport = 168344,
        wizard_waveofforce = 30796,
        x1_barbarian_ancientspear = 377453,
        x1_barbarian_avalanche_v2 = 353447,
        x1_barbarian_warcry_v2 = 375483,
        x1_barbarian_weaponthrow = 377452,
        x1_crusader_akaratschampion = 269032,
        x1_crusader_blessedhammer = 266766,
        x1_crusader_blessedshield = 266951,
        x1_crusader_bombardment = 284876,
        x1_crusader_condemn = 266627,
        x1_crusader_consecration = 273941,
        x1_crusader_crushingresolve = 267818,
        x1_crusader_fallingsword = 239137,
        x1_crusader_fistoftheheavens = 239218,
        x1_crusader_heavensfury3 = 316014,
        x1_crusader_ironskin = 291804,
        x1_crusader_judgment = 267600,
        x1_crusader_justice = 325216,
        x1_crusader_lawsoffate = 290960,
        x1_crusader_lawsofhope = 290912,
        x1_crusader_lawsofhope2 = 342279,
        x1_crusader_lawsofjustice = 266722,
        x1_crusader_lawsofjustice2 = 342280,
        x1_crusader_lawsofvalor = 290946,
        x1_crusader_lawsofvalor_passive = 323387,
        x1_crusader_lawsofvalor2 = 342281,
        x1_crusader_phalanx3 = 330729,
        x1_crusader_provoke = 290545,
        x1_crusader_punish = 285903,
        x1_crusader_shieldbash2 = 353492,
        x1_crusader_shieldglare = 268530,
        x1_crusader_slash = 289243,
        x1_crusader_smite = 286510,
        x1_crusader_steedcharge = 243853,
        x1_crusader_sweepattack = 239042,
        x1_demonhunter_companion = 365311,
        x1_demonhunter_companion_passive = 365312,
        x1_demonhunter_entanglingshot = 361936,
        x1_demonhunter_evasivefire = 377450,
        x1_demonhunter_vengeance = 302846,
        x1_imperius_leapsmash = 293355,
        x1_monk_dashingstrike = 312736,
        x1_monk_epiphany = 312307,
        x1_monk_innersanctuary = 317076,
        x1_monk_mantraofconviction_v2 = 375088,
        x1_monk_mantraofevasion_v2 = 375049,
        x1_monk_mantraofhealing_v2 = 373143,
        x1_monk_mantraofretribution_v2 = 375082,
        x1_monk_mystically_v2 = 362102,
        x1_npc_westmarch_aldritch_crushingresolve = 367807,
        x1_pand_ext_event_greatweapon_bosssuckin = 360331,
        x1_skeleton_stab = 315052,
        x1_wickerman_firephantom = 288538,
        x1_wizard_wormhole = 243141,

    }
}
