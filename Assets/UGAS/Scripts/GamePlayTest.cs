using System;
using AbilitySystem;
using AbilitySystem.Authoring;
using Alchemy.Inspector;
using UnityEngine;

namespace UGAS
{
    public class GamePlayTest : MonoBehaviour
    {
        [SerializeField] AbilitySystemCharacter abilitySystemCharacter;
        [SerializeField] GameplayEffectScriptableObject gameplayEffect;
        GameplayEffectSpec spec = null;
        [Button]
        public void Test()
        {
            // This method is called when the button is clicked
            Debug.Log("Button clicked!");
            // get current ability system character
            abilitySystemCharacter = GetComponent<AbilitySystemCharacter>();
            if (abilitySystemCharacter == null)
            {
                Debug.LogError("Ability System Character not found!");
                return;
            }
            var attributeSystem = abilitySystemCharacter.AttributeSystem;
            if (attributeSystem == null)
            {
                Debug.LogError("Attribute System not found!");
                return;
            }
            /*// get current gameplay effect
            var gameplayEffects = abilitySystemCharacter.AppliedGameplayEffects;
            if (gameplayEffects == null || gameplayEffects.Count == 0)
            {
                Debug.LogError("Gameplay Effect not found!");
                return;
            }
            // print all gameplay effects
            Debug.Log(string.Format(@"Gameplay Effects: {0}", gameplayEffects.Count));
            foreach (var effect in gameplayEffects)
            {
                Debug.Log(string.Format(@"Gameplay Effect: {0}", effect.spec.GameplayEffect.name));
            }*/
        }

        private void Awake()
        {
            // Variables required:
            // abilitySystemCharacter - reference to the Ability System Character component that is performing the action
            // gameplayEffect - reference to the created Gameplay Effect Scriptable Object asset
            // spec = abilitySystemCharacter.MakeOutgoingSpec(gameplayEffect);
        }

        // create a new Gameplay Effect Spec
        [Button]
        public void CreateGameplayEffectSpec()
        {
            // This method is called when the button is clicked
            Debug.Log("Button clicked!");
            spec = abilitySystemCharacter.MakeOutgoingSpec(gameplayEffect);
            Debug.Log("spec created");
            abilitySystemCharacter.ApplyGameplayEffectSpecToSelf(spec);

        }
    }
}
