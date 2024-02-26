extends Area2D

@export var attack_damage: float

func _on_area_entered(area):
	if area is HitboxComponent:
		var hitbox : HitboxComponent = area
		
		hitbox.damage(attack_damage)
