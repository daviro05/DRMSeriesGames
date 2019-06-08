using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace RunAndJump {

	public class TitleScene : BaseScene {

		public Text BuildInfoText;

		private void Start() {
			SetBuildInfo();
			AudioPlayer.Instance.StopBgm();
		}

		private void SetBuildInfo () {
			string info = "V 1.0.0";
			BuildInfoText.text = info;
		}

		public void ActiveZoneOnClick() {
			GoToScene (Scene.LevelSelect);
		}
	}
}
