class ChangeColumnType < ActiveRecord::Migration
  def change
  	change_column :patients, :age, :string
  end
end
