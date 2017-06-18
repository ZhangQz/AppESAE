<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use App\Utilizador1;

class User1 extends Model
{
	protected $table = "users";
	protected $primaryKey = "id";
	protected $fillable = array("numero", "password");
	public $timestamps = true;

	public function utilizador1()
	{
		return $this->hasOne('App\Utilizador1')->withTimestamps();
	}
}
