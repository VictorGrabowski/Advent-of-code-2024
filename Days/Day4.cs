namespace ADVENT_OF_CODE_2024.Days;

public class Day4 : IDays
{
	private const string INPUT = "SAMMSSSSXSAMXMSMASMMSMSSMMSSXMASMAMMAMSSMSMSAXSSXMXMSASXMSAMXSMMXAMXMMSMSSMXSAMXMMASMSMSMMMAXAAXXASXMMXMSSXMASMMSMXAMSMMMMMAMXSASAMXMMXSAMXM\nSAAXAASAASXAAAAAMAAXMAAAMSAAAXAXMAXMSASAASAXAMAMXMSMMAXMAXAMXXAASMSMMAAXXAASASXSXSAMXSAMXAXMSMSMSMMASAMXMSXXAAMSAMMMSMMMAAMAMAXAMXSAMXMAMMAM\nSMMMMSMMMMMSMSXSSSSMMMMMMMMSMMASMXXAMXSXMMMMSAMXAMAAMMMAMSSMMSMMSAAXMSSSSMXMAAXSAMXSAMMMMSXXAAAAAAMMMSSMAMMSSMMSASXMAAMSSXSASMMXMASASMAMMMAM\nSAAXXMASAXAXMMMXAAXASAXXAMXXXXMMASMXMASAMXXAMSXSSSSSMAXAMXXAAAAAMXMMAAAAXXXMMSAMXMMMMMSAAMXSMSMSMSMMAXXMAXMAMAASXMASXSMAMXSASMSSMASXMXSXSSSS\nSSMSSXASXMXSASAMMMMMAAXSAMXXMASMAMMAMXXXMMMMSMXAAMAAXXSSSMSMMSAXSAXASXMMMMXXSXMSAXAMAMMMSMASAXAMAMAMXSXXSAMASMMSASMMAMMSSMMAMAAMMASXMMMAMAAS\nXAXXAMXSMXXSAXXSASMSMAMXAMXMMASMXMMSSSMAXMASMMMMMMSMMMAMAMAAXXXSXMMMMAMXMXMMMAASASXMMMXMAMAMAMAMASMMSMMAXMMASAMSMMXMSMAAAXMAMMMSMXXAMAMAMMMM\nMSMAMMMMAXMMMMSMASAAXAMSSMSXMASMSMAAAASMMSMSAXMASAAAAMASASMSMASMMXAASAMXAAAAMMMMAAMXXSMSXMASXXASAMAXAAMAMXMASAMXSMXSXMMSSMMMMSAMMSSMMXSAXMAS\nSAAXXAAXMXMAMMAMAMMMMXXAXAXXMASAAMMMSXMXAAMMMMMAMXSSXSASASAAMXMAMSMMMMMSSXXSXXXMSMSXMAMSAMXMASMMMSMSXXMASMMASAMASMMMXMAMAMSMMMAMAMMASAMMSAMS\nSMSMXSSSMXSASAMMMSAXASMSMSMSMMMXMXXXXMMMMMXAAMMAXMMMXMAMMMXMSASAMXSMSXAAXMAMMSXMASMXAMXMAMXSAMXAAMXSXASASXMAMAMAXAASXMASAMAAXSMMAXSAMASAMAMX\nMMAMAAAAAMSAMXXMASAMXSAMAMMAAMAAMMMXMASMSMMSSXXAXSMSSSSXMASXSMMASAMSAMMXSAAMASAXMASXSSMXASAMXSXMXXAMSXMASXMAMSMMSSMSAMAMAMSAMXAXMXMMSAMASMMS\nASASMMSMMMMSMXMXASXXXMAMAMSXSMSMSAAAAXSAAXAXMXMSMSAAMAMXMAMMXMSMMASAMMSXSMXSASAMXAXXAAMSMMMSMMASMMMXAXMMMXMXXMAMAAASAMXSMMXMXSMMSSSXSMSAXMAS\nMMMSXAAXAMXAMASMASAXSSSMSXMAAAMAMXSMSMMMMMMXMXAXAMMMMAMXMAXAAMAXMXMMXAXXMAMMMMAAMMSMMMMAAAAAMMAMXAMASMSMMXAMXSAMMMMMASAAXAXSASAMAAXAMAMXMMAM\nXSSSMSSSSSSMSASMSMMMMAMAXAXSMMMSMAMAXAMAMASAAMSMSMSXSASASMSSMSSSXAAXMXSMMAMAASXMXMAXXAXXXMXSMMASMMMAXMAAMMSAMSAMXSXMAMXSMSSMASAMMXMAMAMXAMAS\nXSXMAMXAMAAAMMMXAAMSXMMSMMMMAMAXMAMMSSMASASMMMAAAXXASAXAXMAAAAMMXAMXMASAMASMXMXMAXXSSSSMXSAXASXSAXMSSMSXSAAXAXAXMSAMXSXMAXAMASXMXMSASASMMSAS\nSMMMSMMMMSMMMSMSXSMMAMXXAMASMMMSSXSAAXXXMAMXASXSMSMMMSMXMASMMMAAMSMSMAMAMXXXSXASMSMMMAAAAMMSAMAMXMAAAXAMMMMMSAMMXMAMAXMSMSAMXXAXXASASXMAXMAS\nMAAAAAASAXAAXAAXAXMSMMASAMASXMXMASMMMSAMMXMSASAMAXAAAMXSAXXXXMMXMXAXAMXMMSMAXSMXMAAAMXMMMSMSMMMMMSMXSMMSSSXAAAAXMSMMXMASAMMMMMSMMMMAMXMAMMAM\nSSMSXSMMSMSMSMSMXMAXXMXSAMAXMAMXXXXXAAMSSMAMAMMMSMSMMMAXMASXMSSMSMMMXSAXAAMXMXXASMSMSAMSMAASAMXAAXMXXAXAAMMXSSMMMAMASMAMAMSMSAAAXXMXMMSMAMAS\nXMAXXAXAXMAASXMMSMMMMSMSXMASMSXSXSSMMSXAXMAMAMAMAMXMXMXMMAMAAAMAAAXAASAMSSXSMXSXSXAASMSASMSMAXSMSSMAMMMMXMMXAXAXSAMASMXMASAAMSSMMSMXMAAXMSAS\nSMAXSXMASAMMMAMAMAMXAAASASXMAXAXAAXAXAMXXSASASASXSASASAAMASMMMSSXXMMMSXAMMMAMAMAMMMMSXSASXXXSMXAXXMAMAXXASAMMMMMSAMASMXSMSMSMAMASASAMXMSMMAS\nXMMMAXMASMXAXAMAXAMMSSSSXMAMAMMMSMSXMMSMMMXSXSASMSASAMSAMXSXAAXMXSASXSMAAASAMMSAMXSAMAMAMAMMAMXSMSXMXXMXMSAMXAAMXAMASAMXASAAMAXMSASXSAMAMMAM\nSAMMMXMASXSASXSSSMSAXMAXAXAMXSXAMXSMAAAMASXMAMMMXMAMXMMMSMXXMMSAASAMASASMMSAMASASXMASMMMMSMAMMAXAXASXXSAAMAMSXSMMXMXXASXSMSMSMSAMAMAMMSMSMMS\nSAXMXAMXSMMXAXXAAAAMXAAMMSSSXMMMSAMXMMSSMSAXAMXSXMMSMMMASAXXMMMMMSSMSMMXAASXMASXMASAMAAAAXXSXMMSSMMMAASMMSMMSAAASXMMSAMMXAXMAXMAMAMAMXAASAMX\nSXMMSASASXXMASMSMMMSMMSSXAXMAMMMMXSAMXAMXSMMXSXAXMASASMASXSMMAXMAMAMXMSSMMMAMASXXAMXSSMMXSSMAAAAAXXMMMMXMAMAMMMMMAAXMMMSSMMSSXSSSMSASXMMSAMX\nSAMXAAMASXMAXSAAXMAMXAAMMSMSAMAASASASMXSAMXMASXXMMXXAMMAXAXAXMSMMSAMAMMMAXSXMAXAMAMXXMXMASAMMMXSMMMXMMMXXAMAAAXXSMMMSXXXMAAXMAXAAAXMMXXXSAMX\nSMMAMMMMMAMSMMMSSMXSMMSSMXAMMSSMSASMMMAMASASAMXASXSMMMMSXSXSAMXAXSASMSASAMXAMSMXAAXMASAMXMASAMXMXAAXXAXMSMSMSMSASAMASMSMSMMSMSMSMMMAXASASAMX\nSMSMSAXSXXMAXAAMAMAAAXAXAMAMMXMAMXMMAMXXAXXXAMMXMAAMAXXXAMAMAXMXMMAMXXASXASXMAAMSXSAAMMSXSAMXSSSSSSMSXSAAXAXAMXMSAMASXSAAAXXAMXMASMSXAXAMAMM\nXAASMMXAXSSSSMXSAMXSSMMMMMSXAAMXMAMMASAXSSMSAMMAMSMSASXMAMASMMMSSMMMSMAXXMXMMMSMMASMXMSAMMXMXSAAAXXXAAMXMSXSMMAXSXMASAXAMSMXSSXSASAMMSMMMSMM\nMMMSMXSMXMAMXMAMXSAMMMXAXSAMMXMAXAMSAXMMMAMMMMMMMXAMXXXMMMMSAAAAAAXAXMXMSMSXAXAAMAMMMMMASXSSXMMMMMMMMSMMXSAAXSSMSXSMMMMSXXAMXAASAMAXMAAAAMAX\nASXMMAMXAMAMAMAMAMXSASAXXAMXXAASXMMMMXSAMAMXSAXMAMXMSSSXSAAMMMMXSMMMSXAAAASXSMSXMAMAAASXMAAMMSXXXAAAXXASAMXMMAMXXAAMAMMMMMAXMMMMXMAMMASMXSAM\nMAAAMMXSASASXSMSSMMSASMXMAXXMMMMMXAMXASASMSMSASMMXAMMAAASMSSMSMXMXXAXMSSMXMAXAMXMMXSXMSAMMMMAMXSXSXSSXXMAMAXMSSMMMMMAXAAAXSMAXASXMXXXMAMXXXA\nSSSMXAXAAAMAAAAAAAXMXMASMSMSMAAASXSSMMSMMXAAMAMAMSSMMMMMMMAAAAMMMAMMMXMAXXMAMAMMXSAMASXXMAMMXSAMMMXMMMSMSMSSXAAXXXASXSSSSSXAXMAXASAMXXAXMAMS\nMXMAMXMMXMSSSMMSMMMMMMAXXAAAXSMMMAAMAXMASMMMMAMXMAMXSMXMASMMMMMAMASAAMSAMSMMSMMSAMASMXMASMMSMMMMAMMXAAXAAAXAMMSAMXMXAMAAMMMSMMSSMMAMXMMAASMM\nSSMMSSMXAXAAAMXMASAMXSSMSMSMXMXSMMMMSMMMAAXASMSSMAMMMAASXSXMXSMMXASMSXMASAMAMXAMASASAASMMSASASMSSSMMXMMSMSMSAXXAXAMMSMMMMAAAAXAAMMAMAASMMXAS\nAAAAAAAMMMMSMMAMXXASAXAAMAMMASAMXXAAAASMSSMASAAMSMSMMSMSMMMMASASMAXXXMASMXMASMXSAMAMMXSMAMXSAMAAMAASAMXXXXXASAXAMXXAMASMSMSSSMSSMSMSXMXMASAA\nMSMMSXMXMAMAMMASXMMMXSMXMAMMAMAMSXMSSMMMAMMXMMMMSMAXXAMXXAAMSMAMAMSMMSMMMXSAMMAMXMAMMXXMAMAMAMMMSSMMXMASMXMMMXSSMXMXMXMAXAXMAMXXAAAXMSSMMMSM\nXMXXXMMAMXXAXSASASAAXMAMSXSMASAMXAXAXXXMAXXSASXAMSMMXASXMSMSAMAMXXAAAAAAMMMMSMXMMMMSXMXSAMASAMAXMAMMMMAMMXMXMAXAAAMSAMMMMSMMMSAMMMXMAXAASAMX\nMSMMSASMSSMMMMASAMMSMAMXSMXMAXXSSXMASXSSSSMAAAMXXASAXXMAAAXSXSASXSSSMSSMSXAASXMASAMXAMASMSMSASXSSMMAXMSXSAXAXXSMMMAAAMXXMXAXXMASXMASXSSMMASX\nAAAAXMASAXAAAMMMMXXAAXMASMMMSSXMASMXMAAAASAMXMMMSASMSMAMMSXMASAMXAAAMXMASMMMSAMAXAXXAMASXSAMASAMXXSMSAMASXSMSAMXAXMSXMAXMMXMXXAMXMASAMAASXMX\nSMSMMXMAXSMMXXSAMMSMSSMAXAMAAXXXAXMAMXMMMMMSAXAXMMMAAAXMAMAMAMXMMMMMMXMAXAAAXAMMSSMSSMXSAMXMAMAXAXSXSAMAMAAAAAMAXSXMMXSAASMMSMASXMASASXMMMAS\nXXMMAAXSAMMSAMMASAXSAMMSSMMMSSMMMMSMMAMSXMXSXSMSAMMSSSMMXXMMSSMSXSMXMAMXXSMXMAMAAAXAXXAMXMAMXSSMMSXAXAMXMSMMMSMXSMAXAAMMAMAAASAMAMXSMMAMXMAM\nSAMXSXMMASAMAMSAMMSMMSAMAMXMXMAAAAAMXMMSAMMSAXAXXMMAMAAXXXSAMAAXAXAASXMMXMAMSSMMSSMMSMXMAXAMASXASXMMMMMXMXAMXAMSAXXMMSXMXSMXMMMXMXMXASAMMMSS\nMAMMXAXSAMXXSMMASMSAAMMSAMAAAMSSSSXSASXSAMAMMMMMSXMASAMMMMMASMMMMMSMSAAXAMAMAXAAAMAASAMSMSMSMSMSAMXAAXAXXSMXXAXSAMXSMXXSAMASXASAMXAMAMXSXAXX\nSAMASMMMASXSAMXSXASMMXASAMASMXAMMXMMMSASMMXSXAXAMASAMAMAXASMMMXAXMXXSMMMMSSMMSXMMMSMMXMAMAAAMMMXXSSSXMXXASAAMSMMAMXAAMXMASASAAXAMMSAAMAMMMMM\nSXMMSAAXSAMAMXMXMMMMSMASMMXAMMMMXMMSAMXMMXAAXASASAMASXSMSXSMAMSASMMMMAMXXAXXXXMXXAMMSMSXSMSMSAMXXMAMSXSSMMMMXXAMXSXMMAASAMXSMSSMMAMSMMAMAAAA\nMMSASMMMXMASXSAXAXAASMMMMMMAMSSSMAXAXXMASXMMMMSAMASAMAAAXAMMAMMAAXMXMAMMMMSMSAMXMASAAMMXMXAAXMSMXMAMMMMAAAMMASAMAXMXSSMSASXXAXAXSXMAXSMSSSSS\nXAMASXMASXAXXXSSXMMMSAMXAXSAMSAASMMSXXMSAMXAAAMXMXSXMSMXMMSXSAASXXSASASMAMXAXAMXXXMMMMSAMSSSSMAASMXMAAMXSMSMASAMXXAMXXMSXMMMSMXMXAMXMSAMXAMX\nXSMXMAMAMAMMXMASMAMASMMMMXMASMSMMMAMMAMMMAMSSXMXSAMAAXMSMXAAMXMMMXSASAXXAMMSMSSMSMAASAXAXAAXAXXSMMASXSSMAAAMXSXMAMSMMSXMSAAXXAMSSSMMSMMSXMAM\nSMSMSMMASAMAMXAMMAMXXAXSMMSMSAXMXMASMAMSSSMMMASMMASAMXAAMMMXMAAAXMMXMMSXMSXMXAAAAMXMMSSMMMXSMMSMMXMSXAAXMXXSAMAMMMMAAXAASXXMMSMAAAXMAAMXASMS\nSASMAXMAXAXSAMSSSMSMSMMSAMAAMAMXMMMSXMSXAAMASAMAXAMAMASASXXASMSSSXMXAAMAAAXMMSXSSXSXAAMAXAAMXMXAASXMMSMMXAMXASAXMASMMXMMMSSXAXMMSMSSSSMSAMAM\nMAMSXSMSMSAMXSXAAXAMAAMXXXMSMSMMXMMMAXAMSMMAMASXSSSMMAMAAASMSAXXAASMMASMMMXSAMXAAASMMMSAMMMSAMMAMXASAXSAMSAXAMMSSMSASAAAAXMMSXXMAMMAAXMAMMAM\nMAMSXMAAAXXMMXXMMSMXSXXXMASMMAAAAXSMSMMAMAMXXMMAAAAXMASMMMMMMXSMSMXAMAAXAXAMASMMMMMAXXXMASAAAXMXSMSMSMMMMXAMSAMXAAMAMXSMSMXMASXSSSMMMMASASXS\nXMMMMMAMMMMAASASAXMAMSMXAMXASXSMSMMAXSMASAMMSSMMMSMMMMXMAXXXAAXXAXSXMMXSXSMMXMXXSXSSMSMMMMMSMMMAAXXAXXMASMXMXAXSMMMSMMXAXXXXMAXXMAMXMXAMXAAM\nMXAXAASXSAXXXAMMXSMASAMASMSMMAAMXAMMMAMASAMAAXAMAMAMXAAMSMSMMSSXMMMMMSAMAMAMMMXAXAAXAMXAAXMAMAMMSAMAMMSASASAXXXMASAAAMMXMASMSSSXSXMAMMXMAMXM\nASMSSMAMMMMSAMXSXSMXSAMMXAAXMSMMSMMXXXMASMMMXSAMXSMSSSXSAMAAXAXAMXMAAMASXSAMASASMMMMXMASXSSMSMSXMAMXMAMMSMMXMSMMAMMXAMXAAAXXAAXASXSMMSMASMMM\nXAAAAMAXAMAMXXAXXXXASMMXMSMMXAAXMXSAMXSAMASXMXMXXMAMXAMSASMSMSSMMASMSSXMXSASXMAMXXAAXSXMAXMASXMASXMSMMXAMXXAMAAMSSSSSSXSSXMMMSMMSASAASXXMASM\nSMAMXSMMMXXSAMMSMSMXMXXAXMASMSMMMAMASAAASAMMMAMSMMMMMMMSAMAXMAAASXSAAMAMXSMMMMSMMSASAMAMAMMAMAMXMAXXAAMSSMSMSXSXAAAAAAXMMMMSMAAXMAMMMSAXXXAM\nXXSXMAAMSMMAXSMAAAAXSMSMXSAMAAMAMAMXMMMXMAMAXAXAAASASAAMMMAMMSSMMMMMMXXSAMXXMAMAAAXMASAMASMMXMMSMSMSXMXAAXXXAXMXMMMMMMMMAAXAXMSMMXMXMMMMASMS\nSMMASMAMAAXMMAXMSMMXAAAAAMASXSSSSMSAAXSXMAMSMMSMSMSAMMSSSMSSXMMMAASAMXSMMMXMMSSMMSXMAXXXXSASXSMSAAASXMMSMMMMSSMAXAAXXAASMMSMXMAAXAXMXAXXXMXS\nSASAMXAMMXMXXXAMXASXMMMSMSXMAMAAAMXAMXAMMSXXAASAXMMXMXAAXAXMXAASXSSXXXAAAAAXMAMAMXAMSSXSMMAMAAAMSMMMASAMMXSAMAXMASXSXMXMXAAXASXSMMSMSMSMXAAS\nSXMASMMSSSSMSMMMMMMMAAAXAMXMXMMMSMMSMSMXXMAXMMMAMAAXMMMSMXMASMMXXAMAMMSMMSSMMASAMXAMAAASAMAMSMMMXSMXXMASAAAASXMXAMAMXSAMMXMSXSAXMXAAAAAMXMAS\nMMSAMAMAAXSASXAAASAMMMXSAMXMAXXAAAAAAAXXXMSMSMMMMMASAAMXXMMMMMSMMMMMAAXAXAMMSASASMSMMMMMASXXXMXMSAXSAMSMMMSAMXAAMMAMASASAMMMMMXMMSMSMSMSXMAS\nXAMXSAMMXMMXMASXSSXSXMASXXAXMXMXSSMMSMSXAAAAAXXMASAAMSSXAXASAAAAAMAXXSSXMASASXSAMAAAXAASAMXMAMAMSAMMAMXAXXXASMSMSMSMXMXMMXAAXMAMMAAAXAAXAMAS\nMXSASXMAXMASMXMMMMAAXAMXMSSSSXSAAAXXMAMXXMMSMXAXMMXSXMAMASXSMMSSMSMSSXMXMXMMSAMAMMMMMAXMASXMAMAMMMMSMMSMMSSMAAAAAXXAXMASXSMSMSASXMSMSXXSMMAS\nAAMASXMASMAXSAMXASMMMMSAMSAAAAMXSMMXMAMMMMXXMSMSXMAXAAAMXMMXMXAAAAMMAAXXSAMXMMMASASMXXMAXMASXSMSMMASAAAXMAMXMMMSMSMMMSMSASMAXMAMMAMXXMMMXAXS\nSMMMMAMASMMMMMSSMSAAXAXMMMMMMSAMXAXXMAAAAMXSAAAXAMSSMMMMAXMASMMMSSSSSSMAMXSAXXSMXAXXXXXSAMXAAXAAXMASMSMSMMXAXAMAMXAXAXMXAXMMSMAMSMASMMAASXMX\nMXSASAMMSAASAMXAASMMMMMSAAAAXMXASMMMSSSSSXMMSMXMAMAAMAXSSSMAMAXXAAAXAAMSMMSASMMMMSMMXSAXAXSMMMSMSMMSAAASXSMSMMXASMSMMSAMXMMAAMAMAMASASMMAMMX\nMASXSASAXMMSASXSMSXSMAASMSSSSMMXXXMXAAMXMMAMXSMMAMSSMXMAAXMASMMMMMMMXMAXAMMAMXAAAMAAMAAMSMMAXAAXAAXMXMXMAMMMAAXSXMASXAAAAXMASMAMMXAMXMMMAASM\nMXMMMAMMMMXXAMAMAXASAMXSAMXXAAMXMXMSMSMAMSMSAMXSAMAAMXSMSSSMSAXXAAMAMXASMMMMMSMMXXMXSMXMAXSAMSSMXAMXAMAMXMAMMMMMASAMMMSSMXXXMMASXMMSSXXMSMAA\nXAAAMAMMXSXMXMXMAMMSAMXMAXXSXMMMAAXMAMMAMAAMAXAMAMSMMAXXAAAXXMAXSMMAMSXSASXAASAASXSMSXSAMMMMXMMMAAXXASAMAMAMAAAMAMASAAXAXMMAMMXXAMXAMAXAMXXM\nXXMMMMXMASAMXXAXXXXSMMASMMMMMSAMMSSMXMSXSMXMSMMSSMAMMMSMMSMMMMXMAMSMMMASAMXMXSMMXAAAMAMXXSAMXSASMMSXASASMSSSSSSSMSMMMSXAAXAAMASMMMMASMASMMSS\nMSSSMSSMMSXMASMSMAXSXSXXAMXAASAXSAMXAAXXMXMAXAXAAMAMXMAXAAMMMAASAMASAMXMMMSSMMXSMAMMMSMMMXAMAMAMAAXMMMMMMAMXAAAMAAXMAXMMMASXSASAMXSXXXAAAAAA\nXSAAMAAAXMXMAMAAXXXSXMMSMMXMXSAMXMMSAMSXSXMASXMMSMSSSXSMASXAMSXSASAXMXXMAAXAAAAXMSAXXMAMXSXMXMMMMMMMXAXAMAMMAMASXMMSAXMASAMXMMSXMAAMMMSSMMSS\nXMAMMSSMMMAMAMSMSMAMAMXASMXMAMXMAAMXMASXSXMASXASAMMAMAXXAMMSXMASAMXSMSMSAMSSMMSSMMAXSMSAASXSXAAXAAXXAASMXSMMXXASAMAMMMXAAAMXSAMXMMXSAAAXMAMX\nMAXMAXAXXMAXAXAAXAASAMMMSXMXSXAMXSXAMASAMAMASXMMASMAMMMMMSAXAMAMMMMSAAAXMXMAMAAAAMXMXAMMSMAMSSMSMSMAAXXMAMAAXMASAMSSXMMSSSMAMASMSAMMMSSXMXAM\nASAMXSMMSSSSSSMSMSAMXSAXMASAMXSMXMXXMASASAMXMASXXMMAMMAAMMASXMAXXAAMXMMMSXXAMMSSMMAAMXMSAMAMMMAMAMASXMSMAMAMXSXSXMASAAAAAAMXSAMAMASMXAXAMSAS\nMMASAXAXAAAXMAXXXAMXASXXSAMASAMMAMMXMXSASXSXSAMMSMSMSSSSSMAMXXAXMMSSSSSXMMSMMAMAASXSMXMXASMSAMXMAMMAXMAMASASAMAMMMASXMMXSAMXMAXMXXMAAMSMMAXM\nAXAMASMMMMMMSMMSAMXMXSAXMXSAMXSMAXSMMMSMXMAAMMXAAAAAMAMAMMMXMMMSAAAAXAMAXAAAMXSSMMXAXSMSMMXMMMXMXXMMMSSSMXMMAXXMAMASAXAMXAXSASMXMSAXAMAMMMSM\nMMMMXAXXMAMMXXAXAMSMMMXXXXMAMASXMXXAXAXMAXXXMAMSMSMSMMMASASAAAAMMMMSMMSSMSSSMXMASXSMMAMAXMASAMSMSMSXMAMXAMSSSXSMSSXSAMSSSMMSAMXAAXMMXSXMAXAX\nXAXAMMXMAAMMMMMSAMAXXAMMSXSAMXSAMSSSMSASMSMAMAXMAMAXXXSMSASMSMSSXMAXAXMAMAXAMXXAXMAXAASMMSAXMMAAAAMXMASAMXMAMAMAASAMXMAAAXAMAMMMXXSAXSASXSMS\nSXSMSMAMSXMAAAXMASMSMASAAXSMSMMMMAAXAMMXAAMAMMSMAMSXMAXAMAMAXAAMAXAMMSMSMMMXMMMAXSSMSASMAMMXSXMXMSMXSAMAXAMAMAMXMSXMAMMSMMXSAMXSAXMASMAMMAXX\nSAXXAMXXAASXSXSAASXSAMMMSMSAAMASMMMMMMAMXMSAXSAMAMXMSASXMSMMMMMSXMMSXMAMMXMSAMMSAMXAMAXMSMSASXSXXXAXMASXMASXXAXXMXMMAMXMXSXXASAMMSAXSMMMSSMM\nMAMXMAMXSXMXXXAMXXXMAMMMXAMSMSASAMXAAMMMAMMAMSAMXSXASASAAXXXAXXXXSAAXMAMAAASAAAXMASXMMMMASMAMAAAMMMMSMMMMASASMSMMAASMSMMAMXXSMXMAMXMXASAAAAX\nMSMSMSMAXMSXSAXMASMSAMXAMXMXXMASAMSSXMASXSMMMMMMXMMXMAMMXMSMMMMMMMMMXSAMSSXSMMMXAMXAAXMSMSMSMAMMAAAAXAAXMASAMXAAXSMMXAAMSSXXMASMSMAMMXMMXXMM\nMAAAAAMXMAAAXMMXSAASASMMSMMMXSASAXMXSMXXAAXMASASMXMSMAMXAMMMSAMAAMSSMSAXAMMXAAXSSMSSMXXAXSAMMAMXSXXXSSMSMMSXMSMMMXAXMMMMXAMXMAMAASXXMSSSMSXA\nMMSMSMSSMMMSMAAXAXXXAMXAAAAAAMASAMMAMMMMSMMSXSASASMAMAMSMXAASASXMSAAASXMASMXSMXXXAMAMXSMSMMMSASAXMSMAMMXMAMAXSAMSSXMAAASXMMSMSMSMMXAXXAAASXS\nSMXXAMAMXAMXXMASXMXSAMMXSSMMSMMMAXMAXAXXAAMXAMAMMASASAXAMSMXSXMASMXMMMSXXAAXMMSSMSMAMAAMAAAASASXMAAMAMSMSAXXMMAMAAXSSMXSAMXAAAAAMMSSMMMMMMAM\nAMMSMMSSSSSMSXMAXAAAXXXXMAXAAASXXASMSMXSSMMMMMAXXMSMSXXAMAMMSAMXMAAXASXSAMMMXAAAAASAMXSMXXMMMAMAMSMSAMXAXMMSASMMMSMMASASAMSMSMSMSAAAAMSMXMSM\nMAMXAXAAMMAAMMMAMMMMSXMSMAMMSMMXMAXMAAAMAMSSSSXSMXMASASMMASAMXSXXMXMXSAXSXMAMMMSSMXXXMMMMASXMAMXMXAMXSMSMAAMMMAAXAXSAMXSAMSAMAAXMMSSMMAMAMAM\nSAMXAMMMMSMAMASXMXMXSAAAMASAAAXSXMSSMSMMAMAAXMASAMMAMMAXSXMMXSAMMMSMMMAMXMASXMXAMXXMSMAASAMASMSMAMMMMXAAMMMSMMSMMMXMSSMSXMMAMSMSXXAMXXMXMSAS\nSASMSMAAMMSXSMSAMXSAMMSMSMSMSSMMMXAXXMASMMMSMMMMSASASXMMSMSAXMASXAAAAXMASXMAMXMMMMSAAMXMASXAXMAMXASAMXSMSXSAMXASAXXAAMXMMSSMMMAMMXXXMMSAMSAS\nMAMAXMXMMAMXMASAMAMASAMXMMMXXMASAMMSMSAMMXMAMXXAXXSASXXASASMXSAMMSSSMSMAMXSMSMAXAAMSSMSXAMMXSSXMSASMSAMXXMSAXSASMSMMMSAAMASMAMAMMSMSMAMAXMAM\nSSMSMMASMSMSSMXAMMSAMASXMASMSSMMSSXXASASAMXSSSMXSMMAMMMXMAMAAMAXAMXXXSMMSASXAMSMMXXMXAXMMMAMAAAMXAXAMASXXAXAMMAMXMASXXXSMAXMASMAMAAAMASXMMMM\nSAAXAMAXMXAAMXSAMXMASXMMXAMAAASAMXMAMMAXXMAMAAXMMAMXMASAMAMMMSSMSSSMMSAAMASMXMMXSXSMMMMXASMMMMSAMMMMMMMAMSMSMMAMSSSMASXMMSXSAMXAXMSMSXSASASM\nSMMMSMSSMMMMSMASXXSAMXMMSMSMXMAMSAMSAMXMMMXMSMMSSMMXSASASASXXAAAAXAMXMMMMSMMXAMXMAMXAMXMMXXAXXAMAAASASMXMAAAAMMSAXAXXSAAXAASASXMSAMXMASAMASX\nXSAAXAAAAXMAMMAMXMMMMAXAAAAXMAAXSASXAXMMXSXAAMXXAAAXMXMASAXAMSSMXSMXXXXXXMASMMMXMAMSSXXAMMSMMSMXSXSSXSXASMSMSSSMMSMASMMMMMMMAAAMAMSSSMMSMSMM\nSAMSSMSXMMMASMMSAXAAXSMSXXMSMMMXMXMMAMXMAMMSMSMSSMMSXSMMMXMXMMMAASMXSASMSMAMAASXSMMXAAMMMAAXAAXXXXAMAMMXMMXAAXAAXXXMAMAXXSXMMMAMXSAAAXAXXMAS\nSAMXAXMASASMSAASMMMXSXAMSSSXMAMMMXMXMAAMAMXXAXAAMAMXAMMXAAXAMXSMASAAMXMAMMXSSMSMXSAMXMSAMSXXXMSMMSMMASAAMSMMMSSMMMMSMSMMMMAXXMSMSMMSMMXMAMAM\nSXMMMMMASASAMMMSMSSSMMXMAXSASXMAXXSAMSXMASXMSXMSSSMMAMAMAMSMSAMAMMMMSMMSMMAXXXMAXAMAAXSAMAMMSXSAAXXAAXXXMAXXAXAAASAAXAXAAMMMSXAXXXAAMAAXAMXM\nXMXXXAMAMAMAMXXMAAMAAMSMXMMMMMSMSMSAMMMMSMMAMAAMAMXXMAAXXXAAMXMASXMAAMAAAMMSMMSSMSXMMXMXMASAAASMMMSMSSSXASMMXXXMSASMSSSSXSAAMSSSMMSSMSXMXSSS\nSAMMSSMSSXSXMMSMMMSSMMAAAMAXMXAAAASXMMAXAAMAMMXMAMSMSMMMMMMXMASASAMXSMMSXMMXAMAMXMXMMSMMSASMMXMMMAAAXAMMMMAMMMSMMMAMAAAASXMMXAXAXXMAMMMSMAAS\nAXAAXASAMXMAMAMMMMMMMSXXMXAMXMMXMXMMXXSSXSMSSSMMAMAAAASMXSXXXAMMSAMXXMMXASXSMMMSASASAXMAMASXXAAASXMSMAMAASAMAAAAMXSMMMMMMMASMMMMMMXMMXAAMMMM\nMXSSSSMMSASAMASAAAAXMASASXSSSMXMSMSAXXXSAXAMAAXMASMSMMMAAAMMMMSMXAXASXASXMASAAXMXSAMMSSSMXMASXMMSMXMAASXMSXMMMSMMAMAAXAXAXMSASASAMAASMSMSASX\nXXMAXMAXAASMSXXMSXSXMAXXMAXAXXAAAAMSSMAMSMMXSXMAASXXMXSMSMXAAMAMSSMASMMMAMAMAMXSAMXMMAMAMXAMXAXAXMASXMSXXMASMXMMMAXMSSXSSSXSAMXSASXSMAXXSASM\nSAMXMSMMMAMXMXMXMMXAMAXMMSMAMSSSMSMAXMAMXMMMXAAMXSXXXAXXAXMSMSAMAAMMMAXSXSASAMAMASXXMSSMSASXSSMMMSASASXXMMAXMASAMMSMMMMMAMXMMMXSXMMAMMMXMXMA\nSSSXMAMSMASASMMMAAXAMSSMAMMAMMAAXXMAXSXSAMAAXAMXXMASMSMSMSXAXSMMMSMSMSMAASASMMXSAMXSSMMXSAAASMAXAMXSMXMMMMMSMSMSAAAMAAAXASXMASMMMSSSMSSXMMMS\nSAXAMAMXMMSAXAASMMSSMAAMAMMSSMSMMMMXXAAMMSMSSSSXXMAAAAAXASMMMMMSSXXMAAXMAMMMXSMMXXAXAAMAMMMSMSSMMMAMXSMMAAMAMAAAMSMSSSMSASASASAXAAXMAMAXMASA\nMMMMSMSMMMMXMSAMAAAXMSSMMXAXXMMAMSASMMMMMAMXAAAMSMSMSSSMAMSAASASASAMSMMXXXMASAAASMSSSMMASAXMAAXSMMXSAMAMAMMASXSMXXAMAMMXMSXMASXMMMAMAMMASMSX\nASAMAAAMMAAXXAASMMMXAMXMAMSSMXSAMMASXAXMSASMMMMMXAXXAAXMXMXXXSMMAMXMXAMXSAMXXXMAXAAXAXXASASMMMXAXAMXXSAMXSSXXMAAXMXMSMSAMMXSXMXAXMSXSSXAMMMM\nAXAMMSXSAMXMMSXMMAXASMSMMXAAAXSASMAMXXMASXMASAXAMXMMSMSXMASMXSXMMMMASASAMXXSMSSSMMMMXXSASAMMSSSSMMSMMSXSAMAMMSSMMXXAXASASAAMAMSSMXAAMMMXSAAM\nMMSMAMAXASXMAMXAMXSXXAXASASMMMSAMMSSSMSMSASMMSSSSMXAMXMMSAMXAMAMMMSAMSAMXMASXAAXMAXSAXSAMXMXAAAXXAAAAXAMMSAAXAAAXSMMMMMMAAMMAXMASMMXMAXAMMSS\nXAXMMMASMMXXSAMXMAAXMMMAMMXAMXMMMMMAMAAAMAMXAMMAAMMMMAAXMASMMXSMAAMAMMMSSSMSMMSMSAXMMMMAMSSSMMMMMMSSMMMMMSMSSMSMMXAAAXAXMASXMMSXMXSASMMMSSMM\nMMSAXMASAAXXMMAMMSSXAAMSSMSSMAMMMSAAMSMSMSSMMSMSMMAMSSSXSAMMMAXSMXMSMXXAASAXAXAMMMMMAAMAMAAAMXAAXMAXAAMAXMAAXMAMXSSMSMXSXASASXSXAAMAMAAXMMAX\nXASAMAASMMMMXSAMMMMMSXMXAAAMMXMXAAMXMAXAAAAASXXAXMAMAAXAAMMSMAMASMAMXXMMSMXSXMASAMASXSSSSMSMMXSMMMASXMSMSMMMMMAMXXAXMXMMMMSAMAXXMXXAXSMSXMXM\nMMSSMMMXASXSASXSAAMXXMXSMMMSMSMMMSMSMXSMSMSXMMSSSSSMSSMSMMAXMMSAMMAMASAMXMAMAMXMAXMSAAAAAXMASMAMXMAXMAAAXXMASXMSMSSMMASAAMMMMMMXSAMSAXXXAMMS\nMAMXXXMSXMAMASASXSMMMMMAMAXXMAAAAAAXXAMMXXMAAXAAMAAAXMAAAMXSAAMMMMASAAMXMMSSMSMSSMAXMMMMMMSAASAMSMSSMSMSMMMAMAXAASAXXAXXXMAXAAAAMAXXASASMMAX\nMSSSMAMXSMXMXMAMAXXAASMMMASMSSSMSMSMMASASASMMMMSMSMXMMSXSMMMMXSXSSXMMSSXXAMAAXMAXMXMMXXASAMXMMXMXAXXXXXXAMMSMMSMSXMMMSSMSSMSSSSXMSMMAMMAXMMS\nXAAAMMMAXXXSSMSMMMMSMMASXSXMAMAAAAAXXSMAMAXXAAXMAXXMXXMAMXAAMMXAMXMASAAXSASMMMMASMSMSASAMAMSXMMSMMMMMMASXMAXXXAMXMXXXMAXXAAXXMAMMAMMXMXMXXAM\nMMSMMSAMXMMXSAAXMAXXXMAMXMXMASMMMSMXSAMSMSMSSMSMAMXAMAXMASXSSMMMMASMMMSMSASXSXMASMAAXASMSMMXAMXAAAXMAMAXASASMXMXSAMXXSXMSSMXSXXMSMSSSMASAMMS\nXAAXXMAXAMMAMMMXSMSAMMSSSMASMSXXXAAXXMMAAMAAXAXASMMSAMSMMMMAAAAXXXSXAXAAMAMAMAMXSMMSMMMMAMSSMMSSSMSXSSMSXMASMXSAMSMMMMAAMXMAMMMXAXSAXSAMASAA\nMMSSMSMSMSXXSASXMAMXMAXAXMASMXMMSMMMSSSMSMMMMMMMMAXAXXAXAMMSSSMMMXMXMSMSMXMMSAMAXAXMXAASMSXASAAMMXSMXAASAMAXAAMMXAMAAMSSMAMASAAMMXMMMMXSAMXS\nMXAAXAAAAMMMMASXMSMSMXSAAMASXMAMAAMSAMXMXXXMMAAASXMSMSXSXXMAMAAXSXMAMAMAMMMXMASXSAMMSSXXXXXMMMSSMAMAMMMSAMAMMMSSSMSMXMAAMXSSXASXMASXSAMXASAM\nXMASMMSMSMAAMAMMAMAAAXXAAMASAASXSSMMXXAMAMXMMSSMSSMAAXASMSMASMMMMAMSSMSAMAMSSMMXAMAMXMASXXAXAXXXMMSAXMASAMXXXXAAAASAMXSSMMSAMXMXSASASMASXMAS\nMXMAMXAXAXXSSXSASMSMMMAMMMMSASXMAMAXSMMXAAMAAXXMMAMMMMMMAXSAMAMASXMMAMSMSSSMAAAMXSAMMXMAMXMSSSMMMASASMASXMAMMMMSMMMMMAMXAXMASMSXMASAMMMAXMAM\nAAXXSSMSMXSAMAXMXAAAASAMAXXSXMMMMSXMXASXSSXMMSAMSSMMXSAMSMAMSSMAAMMSAMXXAMAMSMMMASASMXMSXSXAXAAAXMMMMMMMMXXAXXAXXAAAMXXSMMSAAASAMXMXXXXMXMAS\nSASMXAAMMMAAMMMMMSMMMMASXSMXAMXXAXMXMMMAMXMMXSAMAMAAAMAMXAMXAXMMMXASASXMMSMMMXXMASAMXXXMASMMSMMMMAAAXASAMXXSXMMSSSXSAXAASAMSSMSXMASMMMMXASMS\nMASASMXMAXSSMXAXAMMXSSMMAMMSMMXMMMAMAXMXMAMSAMXMXSXMAXAMMSXMASXMXMASAMMXAAAAMSMMMMASMSMMXMAXXXAMXSMMMMSASMMMXXAAMMAAAXSAMXMAMXMAMXSAAMASMSAM\nMAMMXXAMMXXAMSSXMSMAXAXSMSMAAXMASASMSXMASAMMMMSAMXXMMSXSAXXSXSASAAMMAMSMSSSSSXMAMXAMMAMXMSSMSMMSAMAXSASAMAAXMMMSSMSMSMMAMXMSMSMSMMMMMSAMMSMS\nMMMMMSSSSMSAMAXAAXMSSMMMAAMMXXAMXAMAMASASMSXSASMMMXXAAXMMSAMAMAMXMXMASAAMAAMAMXASMSMSASAAAMSXAAMASAMMXMAMSMSAMMAXXXAAXSAMAXASAAAAAAXXMASASXX\nAMAXMAAAAMSAMASMMMMMAAAMSMSMMSSMMSMMMAMASAXAMMSAAAMMMMSXMMAMXMMMSMMXXMASMMMMSAMSAMXAXAXXMMSAMMMMXMMMSXSSMMMAMXMSSXMXMAXMMMSXXMSMMMSSXSAMXSMM\nASASMMMSMMSAMXSAXXXXMMMXAAXAXAAAAXAXMMMXMMMXMASXMMSAASXMSSMSMSAAAXAXSAMXXAMAXAMXASMMMAMXMXXMSXSXAAAXXMAMXXMASMMMMAXAXMXSAMXXMXAXXMXMASXSMSXA\nXMASAXXAXXSAMXSXMAMSASXXAMSMMSSMMMAMXMMAMXMXMXMAMASXSXAAMAAAAXMMMSSMSAMXSXSAMAMSASAXXMAXMAMXAASXSMMXMASMMXMAMAAAXXSMSMAMAMAASAAAMSMSXSAMXMMX\nXMXSAMSSSMXXMAXAMAASAMMXXMAXAAXXSAMMAXSMSAMASAXAMXSMMMSSSMMMSMMSAAMAMXMASMMMSXMMASXMMSMSASXMMXMAMXXMSAMAXSMMSMSXSAMXAMMSMMMXAAAMSAASAMMMASMM\nXXAMAMAAAMXXMSSXMXMMSMMMMSASMXSASAASXMXMAASAMMXSAMXAAAMMXXSAMASAMXSSMSMAMXAAAMXMXMMMAAAMXXAMXMMAMMMMAAXXMMAASXMMSASXMXMAMSSSMXSXMMMMAMASMSAS\nSMXSMMXSAMMAAXMASMAXAXAAXXXXAAAAXXMXXXMAXMMXSXAMAXMSMSXSXMMAMXMMMMAAASMMMSXSMXMAMAAMMMSMASMMAMMAXAAXSSMSMXMXMASASAMMSAMMAMAAXAMAMXSSXMASXSAM\nMAXMMAMXAAMMSMSAMSMMMSSSSSSMSMMSMSMSSSSXSAMXAMSSMSAMAMMMASXSMSXXXAMMMMASAAMXAXSAMMMXAAAMXXASASMMSXXMAXAAAXMAMMMMMAMAMXSMAMXMMSXMMAAMMMASXMAM\nMSMMAMMMMMXAAXMMXAXAXXAAAAXAMXXAXAAAAXAASAMXMAMAAMAMAMASMMAXAMXMAMXAXXAMMSAMXMSASXXSMSMSXMMMASXAAASMMMSMSMSASXASAMMSSSXMASMSMMASMMSSSMMSMXAA\nAAAXXMASXSMSSSSMSXSMMMMMMMMSMMMMSXMMSMSMXMXXXSXMXMXMXSXMXXXMAMXMASMSSMSSXMXSXASAMMXAMXMXXAXMXMMMMXMAMXXAXAXAXMAXAASXMMASXMXXASAMMXAAXAMXASMS\nSSSMSMASAAAXMMMASMSASASMSMAMAMMXSMMXXAMXAMSMMMXMASXMAMMMMMMSXMXSAAAAAMAMXXAMMMMAMXMMMSASMSMSMMASXMSMMAMMMMMMMSMSSMMASMMMMMSMMMMMSMMSSSMSMMAA\nMAAAXMAMMMMMAAMMMASASASAAMASAMAAMASAMSSSXSAAAXASXSAMXSAAAAMMMAAMAMMMSMASMMXSAASAMAAXXMAMMAAAASASAAAAMASAAAAAAAXXAASAMXAAAAAAAXAAAXAAMAMXAMXM\nMSMMMMMSAMXSSMSXMMMXMXMMMSMSMSXXSSMXSAMXSSMSMSMSASMMSSMSSSXAXMXSXMASMXMSXXASXMSXMAMSAMXMSXSSXMSSMMMASMSXSSSMSSSSSMMMSXSSSSSSMSMSSSMXSSMSMMAX";
	public string Part1()
	{
		int result = 0;
		string[] lines = INPUT.Split('\n');
		for (int x = 0; x < lines.Length; x++)
		{
			for (int y = 0; y < lines[0].Length; y++)
			{
				if (lines[x][y] == 'X')
				{
					// Console.WriteLine("Found X at: x:" + x + ", y:" + y);
					//Call the function to search for XMAS
					result += SearchForXMAS(x, y, lines);
				}
			}
		}
		//Not the willing to do it today but will try to take a guess as how i'll do it:
		//Split input file into lines (.Split("\n");
		//Then Create a function that searchs for the word XMAS in all directions starting from an X
		//example:
		//XXXXMASX
		//MASXXXAM
		//AXXXXXMA
		//SXXXXXXS
		//This input should return 4
		
		//We must cycle between each char of all lines from top to bottom and increment the res when the SearchForXMAS(x,y) function returns true.
		
		return "Day 4 Part 1's result: "+ result ;
	}
	private int SearchForXMAS(int x, int y, string[] table)
	{
		int cpt = 0;
		//We must check if the word XMAS is in the line, column and diagonals
		//If it is we must increment the cpt variable for each word found
		//Example:
		//Second example:
		//SAMXMAS has 2 time the word XMAS, one time in the the right order and another time in the reverse order.
		
		
		//For the coordinate of the X, Search in every possible direction for the following letters in this particular order: [M.A.S]
		//Be careful with borders of the grid, we must not go out of the grid.
		char[] word = { 'M', 'A', 'S' };
		//i must check if the word is in the line
		try
		{
			if (table[x + 1][y] == word[0] && table[x + 2][y] == word[1] && table[x + 3][y] == word[2])
			{
				cpt++;
			}
		}
		catch (IndexOutOfRangeException e)
		{
			
		}

		try
		{
			if (table[x - 1][y] == word[0] && table[x - 2][y] == word[1] && table[x - 3][y] == word[2])
			{
				cpt++;
			}
		}
		catch (IndexOutOfRangeException e)
		{
			
		}

		try{
			if (table[x][y + 1] == word[0] && table[x][y + 2] == word[1] && table[x][y + 3] == word[2])
			{
				cpt++;
			}
		}catch (IndexOutOfRangeException e)
		{
			
		}

		try{
			if (table[x][y - 1] == word[0] && table[x][y - 2] == word[1] && table[x][y - 3] == word[2])
			{
				cpt++;
			}
		}catch (IndexOutOfRangeException e)
		{
			
		}

		try{
			if (table[x + 1][y + 1] == word[0] && table[x + 2][y + 2] == word[1] && table[x + 3][y + 3] == word[2])
			{
				cpt++;
			}
		}catch (IndexOutOfRangeException e)
		{
			
		}

		try{
			if (table[x - 1][y - 1] == word[0] && table[x - 2][y - 2] == word[1] && table[x - 3][y - 3] == word[2])
			{
				cpt++;
			}
		}catch (IndexOutOfRangeException e)
		{
			
		}

		try{
			if (table[x + 1][y - 1] == word[0] && table[x + 2][y - 2] == word[1] && table[x + 3][y - 3] == word[2])
			{
				cpt++;
			}
		}catch (IndexOutOfRangeException e)
		{
			
		}

		try{
			if (table[x - 1][y + 1] == word[0] && table[x - 2][y + 2] == word[1] && table[x - 3][y + 3] == word[2])
			{
				cpt++;
			}
		}catch (IndexOutOfRangeException e)
		{
			
		}

		return cpt;

	}

public string Part2()
{
	string resDay3 = "";
		   
		    //Je retourne le résultat
		    return "Day 4 Part 2's not done yet";
}
}