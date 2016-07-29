class CreatePatients < ActiveRecord::Migration
  def change
    create_table :patients do |t|
      t.string :last_name
      t.string :first_name
      t.string :phone
      t.string :age
      
      t.timestamps null: false
    end
  end
end
