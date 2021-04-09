using UnityEngine;

public class Player : MonoBehaviour {
	
	private IWeapon _currentWeapon;
	private HandGun _handGun;
	private ShotGun _shotGun;
	private NuclearMissileLauncher _nuclearMissileLauncher;

	void Start () {
		// we halen even de andere components op
		_handGun = GetComponent<HandGun>();
		_shotGun = GetComponent<ShotGun>();
		_nuclearMissileLauncher = GetComponent<NuclearMissileLauncher>();

		// we laten currentWeapon verwijzen naar de shotGun
		_currentWeapon = _shotGun;

		// waarom gebruiken we een interface?
		// omdat Classes alleen maar van elkaar mogen weten wat je bij elkaar mag doen. Niet 'hoe' het gebeurd.
		// Standaard regel: Program to an interface, not an implementation
		// met 'implementation' bedoeld men dat je hard tegen een bepaalde Class Type (bijvoorbeeld HandGun) aanscript
		// met interfaces wordt het heel duidelijk wat je mag verwachten van een Class. In de grote mensenwereld wordt
		// veel gewerkt met interfaces. .Net heeft hele conventies over welke interfaces je zou moeten hanteren
	}


	void OnMouseDown(){
		_currentWeapon.Shoot();
	}
}
