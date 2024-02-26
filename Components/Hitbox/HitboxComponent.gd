extends Area2D
class_name HitboxComponent

@export var health_component : HealthComponent
@export var animation_player : AnimationPlayer

func damage(attack : float):
	if health_component:
		health_component.damage(attack)
	if animation_player:
		animation_player.play("damage")
